using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Threading;

namespace TMAVerify.Models
{
    class DbHelperBOSS
    {
        public struct ActionType
        {
            public const int Error = 0;
            public const int Insert = 1;
            public const int Delete = 2;
        }

        //registerFlag = 0 : Đăng ký liên kết (BTMVLocalDev)
        //registerFlag = 1 : Đăng ký liên kết (FAWireless)
        //registerFlag = 2 : Đăng ký liên kết (FATerminal)
        //registerFlag = 3 : Đăng ký liên kết (BOSS)
        //registerFlag = 4 : Đăng ký FIFO
        //registerFlag = 5 : Đăng ký sử dụng
        //registerFlag = 6 : Gỡ tự động sau khi có liên kết mới
        //registerFlag = 7 : Gỡ tự động sau khi kết thúc thẻ
        public struct RegisterFlag
        {
            public const int RegisterLinkage = 0;
            public const int RegisterLinkageFAWireless = 1;
            public const int RegisterLinkageFATerminal = 2;
            public const int RegisterLinkageBOSS = 3;
            public const int ReigsterFIFO = 4;
            public const int ReleaseFIFOUsing = 5;
            public const int ReleaseFIFONewLinkage = 6;
            public const int ReleaseFIFOEndUse = 7;
        }

        public static bool Error = false;
        public static string ErrorMessage = "";
        static OracleConnection _OracleConnection = new OracleConnection();

        /*---------------------------- Các phương thức kết nối tới cơ sở dữ liệu ----------------------------*/

        #region Các phương thức kết nối tới cơ sở dữ liệu
        /// <summary>
        /// Xâu kết nối
        /// </summary>
        public static string ConnectionString
        {
            get { return _OracleConnection.ConnectionString; }
            set
            {
                Error = false;
                try
                {
                    _OracleConnection = new OracleConnection(value);
                    _OracleConnection.Open();
                    _OracleConnection.Close();
                }
                catch (Exception ex)
                {
                    Error = true;
                    ErrorMessage = ex.Message;
                }
            }
        }

        /// <summary>
        /// Thiết lập kết nối sử dụng Window Authentication Mode
        /// </summary>
        /// <param name="DataSource">Server Name</param>
        /// <param name="InitialCatalog">Database Name</param>
        /// <param name="ConnectTimeout">Timeout</param>
        ///User Id = BOSS; Password = BOSS; Data Source = (DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 10.118.11.26)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = BOSSDB)))
        public static void SetConnection(string DataSource, string UserId, string Password)
        {
            OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();
            builder.DataSource = DataSource;
            builder.UserID = UserId;
            builder.Password = Password;
            ConnectionString = builder.ConnectionString;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/


        /*------------------ Các phương thức trả về một DataTable từ một câu lệnh truy vấn ------------------*/

        #region Các phương thức trả về một DataTable từ một câu lệnh truy vấn
        /// <summary>
        /// Phương thức thực thi câu lệnh truy vấn trả về kết quả là một DataTable
        /// </summary>
        /// <param name="TruyVan">Câu lệnh truy vấn</param>
        /// <returns>DataTable chứa kết quả truy vấn</returns>
        public static DataTable GetData(string Query)
        {
            Error = false;
            DataTable tbl = new DataTable();
            try
            {
                int i = 0;
                while (_OracleConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _OracleConnection.Open();
                OracleDataAdapter adp = new OracleDataAdapter(Query, _OracleConnection);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
            }
            finally
            {
                if (_OracleConnection.State != ConnectionState.Closed)
                    _OracleConnection.Close();
            }
            return tbl;
        }
        /// <summary>
        /// Phương thức thực thi câu lệnh truy vấn trả về kết quả là true/false
        /// </summary>
        /// <param name="TruyVan">Câu lệnh truy vấn</param>
        /// <returns>Trả kết quả truy vấn true/false</returns>
        public static bool CheckData(string Query)
        {
            Error = false;
            bool result = false;
            DataTable tbl = new DataTable();
            try
            {
                int i = 0;
                while (_OracleConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _OracleConnection.Open();
                OracleDataAdapter adp = new OracleDataAdapter(Query, _OracleConnection);
                adp.Fill(tbl);
                adp.Dispose();
                result = tbl.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
            }
            finally
            {
                if (_OracleConnection.State != ConnectionState.Closed)
                    _OracleConnection.Close();
            }
            return result;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/


        /*---------------------------------- Các phương thức xử lý dữ liệu ----------------------------------*/

        #region Các phương thức xử lý dữ liệu
        /// <summary>
        /// Phương thức cho phép thực thi một câu lệnh sửa đổi dữ liệu
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQuery(string Query)
        {
            Error = false;
            try
            {
                int i = 0;
                while (_OracleConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _OracleConnection.Open();
                OracleCommand command = new OracleCommand(Query);
                command.Connection = _OracleConnection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
            }
            finally
            {
                if (_OracleConnection.State != ConnectionState.Closed)
                    _OracleConnection.Close();
            }
        }

        public static void ExecuteQueryUsingTran(string[] Query)
        {
            Error = false;
            try
            {
                int i = 0;
                while (_OracleConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _OracleConnection.Open();
                OracleCommand command = _OracleConnection.CreateCommand();
                OracleTransaction transaction;
                // Start a local transaction
                transaction = _OracleConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                // Assign transaction object for a pending local transaction
                command.Transaction = transaction;
                try
                {
                    foreach (string item in Query)
                    {
                        if (!String.IsNullOrEmpty(item))
                        {
                            command.CommandText = item;
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Error = true;
                    ErrorMessage = e.Message;
                    System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_OracleConnection.State != ConnectionState.Closed)
                    _OracleConnection.Close();
            }
        }

        /// <summary>
        /// Phương thức thực thi một câu lệnh truy vấn sử dụng TRANSACTION
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQueryUsingTran(string Query)
        {
            ExecuteQuery(Query);
        }

        /// <summary>
        /// Phương thức thực thi một câu lệnh truy lấy dữ liệu
        /// </summary>
        /// <param name="Query">Câu lệnh truy vấn</param>
        /// <returns>Số bản ghi của bảng</returns>
        public static bool CheckExist(string Query)
        {
            DataTable tbl = new DataTable();
            tbl = GetData(Query);
            return (tbl.Rows.Count > 0);
        }

        /// <summary>
        /// Thực hiện truy vấn đếm số bản ghi trong bảng, thường dùng để kiểm tra tồn tại của mã đối tượng
        /// </summary>
        /// <param name="queryString">Chuỗi truy vấn</param>
        /// <returns>Số bản ghi thỏa mãn điều kiện</returns>
        public static int RowCount(string Query)
        {
            int numRows = -1;
            try
            {
                int i = 0;
                while (_OracleConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _OracleConnection.Open();
                OracleCommand command = new OracleCommand(Query, _OracleConnection);
                numRows = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_OracleConnection.State != ConnectionState.Closed)
                    _OracleConnection.Close();
            }
            return numRows;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/
    }
}
