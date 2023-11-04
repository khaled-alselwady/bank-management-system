using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsClientDataAccessLayer
    {
        public static bool GetClientInfoByID(int ClientID, ref string AccountNumber,
            ref string PinCode, ref decimal Balance, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (decimal)reader["Balance"];
                    PersonID = (int)reader["PersonID"];

                }

                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static bool GetClientInfoByAccountNumber(string AccountNumber,
            ref int ClientID, ref string PinCode, ref decimal Balance, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Clients WHERE AccountNumber = @AccountNumber COLLATE SQL_Latin1_General_CP1_CS_AS";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (decimal)reader["Balance"];
                    PersonID = (int)reader["PersonID"];

                }

                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static int AddNewClient(string AccountNumber, string PinCode,
            decimal Balance, int PersonID)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"IF NOT EXISTS (SELECT Found = 1 FROM Users WHERE PersonID = @PersonID)
                             BEGIN
                                    INSERT INTO Clients (AccountNumber, PinCode, Balance, PersonID)
                                    VALUES (@AccountNumber, @PinCode, @Balance, @PersonID);
                                    SELECT SCOPE_IDENTITY();
							
                             END";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    ClientID = insertID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }


        public static bool UpdateClient(int ClientID, string AccountNumber,
            string PinCode, decimal Balance, int PersonID)
        {
            int EffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"IF NOT EXISTS (SELECT Found = 1 FROM Users WHERE PersonID = @PersonID)
                             BEGIN
                                   UPDATE Clients
                                   SET   AccountNumber = @AccountNumber,
                                         PinCode       = @PinCode,
                                         Balance       = @Balance,   
                                         PersonID      = @PersonID
                                   WHERE ClientID    = @ClientID;
                             END";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                EffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (EffectedRows > 0);

        }


        public static bool DeleteClient(int ClientID)
        {
            int EffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                EffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (EffectedRows > 0);

        }

        public static bool DeleteClient(string AccountNumber)
        {
            int EffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Clients WHERE AccountNumber = @AccountNumber COLLATE SQL_Latin1_General_CP1_CS_AS";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                EffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (EffectedRows > 0);

        }


        public static bool IsClientExists(int ClientID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found = 1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static bool IsClientExists(string AccountNumber)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found = 1 FROM Clients WHERE AccountNumber = @AccountNumber COLLATE SQL_Latin1_General_CP1_CS_AS";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM EntireClientInfo";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static decimal GetTotalBalances()
        {

            decimal TotalBalances = 0M;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TotalBalance = SUM(Clients.Balance)
                             FROM Clients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal TotalFromDB))
                {
                    TotalBalances = TotalFromDB;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return TotalBalances;
        }

        public static DataTable GetInfoTotalBalances()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT EntireClientInfo.AccountNumber,
                             EntireClientInfo.FullName AS ClientName,
                             EntireClientInfo.Balance
                             FROM EntireClientInfo";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddTransferLog(DateTime dateTransfer, string SourceAccount,
                                         string DestinationAccount, decimal Amount,
                                         decimal SourceBalance, decimal DestinationBalance,
                                         string User)
        {

            int TransferLogID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TransfersLog (Date, SourceAccount, DestinationAccount, Amount, SourceBalance, DestinationBalance, Username)
                             VALUES (@Date, @SourceAccount, @DestinationAccount, @Amount, @SourceBalance, @DestinationBalance, @Username);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Date", dateTransfer);
            command.Parameters.AddWithValue("@SourceAccount", SourceAccount);
            command.Parameters.AddWithValue("@DestinationAccount", DestinationAccount);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@SourceBalance", SourceBalance);
            command.Parameters.AddWithValue("@DestinationBalance", DestinationBalance);
            command.Parameters.AddWithValue("@Username", User);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int insertID))
                {
                    TransferLogID = insertID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return TransferLogID;
        }

        public static DataTable GetAllTransfersLog()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TransfersLog";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

    }
}
