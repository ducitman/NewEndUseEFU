using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace TMAVerify.Models
{
    class DbHelperTMADB
    {
        public static bool Error = false;
        public static string ErrorMessage = "";
        static SqlConnection _SqlConnection = new SqlConnection();

        /*---------------------------- Các phương thức kết nối tới cơ sở dữ liệu ----------------------------*/

        #region Các phương thức kết nối tới cơ sở dữ liệu
        /// <summary>
        /// Xâu kết nối
        /// </summary>
        public static string ConnectionString
        {
            get { return _SqlConnection.ConnectionString; }
            set
            {
                Error = false;
                try
                {
                    _SqlConnection = new SqlConnection(value);
                    _SqlConnection.Open();
                    _SqlConnection.Close();
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
        public static void SetConnection(string DataSource, string InitialCatalog, string UserId, string Password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = DataSource,
                InitialCatalog = InitialCatalog,
                UserID = UserId,
                Password = Password
            };
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
                while (_SqlConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _SqlConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(Query, _SqlConnection);
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
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
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
                while (_SqlConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _SqlConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(Query, _SqlConnection);
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
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
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
                while (_SqlConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _SqlConnection.Open();
                SqlCommand command = new SqlCommand(Query);
                command.Connection = _SqlConnection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + "---------------------------" + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + Query + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
        }
		
		public static void UpdateByte(string Table, string ImageColumn, byte[] Value, string Condition)
        {
            Error = false;
            try
            {
                if (_SqlConnection.State == ConnectionState.Closed) _SqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = _SqlConnection;
                command.CommandType = CommandType.Text;
                if (Condition == "")
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = @part";
                else
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = @part" + " where " + Condition;
                command.Parameters.AddWithValue("@part", Value);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
        }
		
        /// <summary>
        /// Phương thức thực thi một câu lệnh truy vấn sử dụng TRANSACTION
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQueryUsingTran(string Query)
        {
            ExecuteQuery("BEGIN TRANSACTION;" + Query + "; COMMIT;");
        }

        public static void ExecuteSqlTransaction(string connectionString, string[] query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    foreach(var queryCommand in query)
                    {
                        command.CommandText = queryCommand;
                        command.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
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
                while (_SqlConnection.State == ConnectionState.Open && i < 3)
                {
                    Thread.Sleep(1000);
                    i++;
                }
                _SqlConnection.Open();
                SqlCommand command = new SqlCommand(Query, _SqlConnection);
                numRows = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
                System.IO.File.AppendAllText("C:/log/test.txt", "\r\n" + ErrorMessage + ":" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
            return numRows;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/
    }
}
