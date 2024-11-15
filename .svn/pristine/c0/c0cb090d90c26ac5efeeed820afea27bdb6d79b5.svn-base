using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace TMAVerify.Models
{
    class DbHelperBBQA
    {
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
                _OracleConnection.Open();
                OracleDataAdapter adp = new OracleDataAdapter(Query, _OracleConnection);
                adp.Fill(tbl);
                adp.Dispose();
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
                _OracleConnection.Open();
                OracleCommand command = new OracleCommand(Query);
                command.Connection = _OracleConnection;
                command.ExecuteNonQuery();
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

        public static void ExecuteQueryUsingTran(string[] Query)
        {
            Error = false;
            try
            {
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
