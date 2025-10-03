
using FirstBankProject;
using System;
using System.Data;
using System.Data.SqlClient;



namespace SimpleSystemBank
{

    public static class clsClientsDataAccess
    {


        public static bool GetClientByClientID
            (
             int ClientID,
            ref string AcNumber,
            ref string PinCode,
            ref decimal AccountBalance,
            ref int PersonID,
            ref string FirstName,
            ref string LastName,
            ref string Gender,
            ref string Email,
            ref string Phonenumber
            )
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Clients.ClientID, Clients.AccountNumber, Clients.PinCode, Clients.AccountBalance, Persons.FirstName,Persons.PersonID, Persons.LastName, Persons.Gender, Persons.Email, Persons.PhoneNumber
                             FROM       Clients INNER JOIN
                                            Persons ON Clients.PersonID = Persons.PersonID
                                                        WHERE ClientID = @ClientID";



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    isFound = true;

                    ClientID = (int)Reader["ClientID"];
                    AcNumber = (string)Reader["AccountNumber"];
                    PinCode = (string)Reader["PinCode"];
                    AccountBalance = (decimal)Reader["AccountBalance"];
                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Gender = (string)Reader["Gender"];
                    Email = (string)Reader["Email"];
                    Phonenumber = (string)Reader["PhoneNumber"];


                    Console.WriteLine();
                }
                else
                {
                    isFound = false;
                }

                Reader.Close();


            }

            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                Connection.Close();
            }


            return isFound;
        }

        public static bool GetClientByAccNumber
            (
            ref int ClientID,
             string AccountNumber,
            ref string PinCode,
            ref decimal AccountBalance,
            ref int PersonID,
            ref string FirstName,
            ref string LastName,
            ref string Gender,
            ref string Email,
            ref string Phonenumber
            )
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Clients.ClientID, Clients.AccountNumber, Clients.PinCode, Clients.AccountBalance, Persons.FirstName,Persons.PersonID, Persons.LastName, Persons.Gender, Persons.Email, Persons.PhoneNumber
                             FROM       Clients INNER JOIN
                                            Persons ON Clients.PersonID = Persons.PersonID
                                                        WHERE AccountNumber = @AccountNumber";



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    isFound = true;

                    ClientID = (int)Reader["ClientID"];
                    AccountNumber = (string)Reader["AccountNumber"];
                    PinCode = (string)Reader["PinCode"];
                    AccountBalance = (decimal)Reader["AccountBalance"];
                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Gender = (string)Reader["Gender"];
                    Email = (string)Reader["Email"];
                    Phonenumber = (string)Reader["PhoneNumber"];


                    Console.WriteLine();
                }
                else
                {
                    isFound = false;
                }

                Reader.Close();


            }

            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                Connection.Close();
            }


            return isFound;
        }
        public static bool FindLastClient(ref string AcNumber)
        {   
           
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT TOP 1 AccountNumber
                             FROM Clients
                             ORDER BY ClientID DESC; ";
                            



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountNumber", AcNumber);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    isFound = true;
                    AcNumber = (string)Reader["AccountNumber"];
                    
                    Console.WriteLine();
                }
                else
                {
                    isFound = false;
                }

                Reader.Close();


            }

            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                Connection.Close();
            }


            return isFound;
        }

        public static int AddNewClient(
             string AcNumber,
             string PinCode,
            decimal AccountBalance,
            int PersonID,
            string FirstName,
            string LastName,
            string Gender,
            string Email,
            string Phonenumber)

        {

            int ClientID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string Query1 = @"insert into Persons(FirstName, LastName,Gender, Email, PhoneNumber) 
                 values( @FirtstName, @LastName,@Gender, @Email,@PhoneNumber)
                 insert into Clients(AccountNumber, PinCode, AccountBalance, PersonID)  
                 values( @AccountNumber, @PinCode ,@AccountBalance, (select top 1 SCOPE_IDENTITY() from Persons )) 
                select top 1 SCOPE_IDENTITY() from Clients;";
        

            SqlCommand Command = new SqlCommand(Query1, Connection);

            Command.Parameters.AddWithValue("@FirtstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gender",Gender);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@PhoneNumber", Phonenumber);
            Command.Parameters.AddWithValue("@AccountNumber", AcNumber);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);


            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;

                }
            }
            catch (Exception ex)
            {
               

            }
            finally
            {
                Connection.Close();

            }

            return ClientID;


        }

        public static bool UpdateClient(
            int ClientID,
            string AcNumber,
            string PinCode,
            decimal AccountBalance,
            int PersonID,
            string FirstName,
            string LastName,
            string Gender,
            string Email,
            string Phonenumber
            )
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"UPDATE Clients SET AccountNumber = @AccountNumber, PinCode = @PinCode, AccountBalance = @AccountBalance WHERE ClientID = @ClientID;
               UPDATE Persons SET FirstName = @FirstName, LastName = @LastName,Gender = @Gender, Email = @Email, Phonenumber = @Phonenumber WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gender",Gender);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phonenumber", Phonenumber);
            Command.Parameters.AddWithValue("@AccountNumber", AcNumber);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            int RowsAffected = 0; 

            try
            {

                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool DeleteClient(int ClientID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"Delete Clients from Clients where ClientID = @ClientID;";

                              

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);
            int RowsAffected = 0;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }


        public static DataTable GetTotalClients()
        {
            DataTable DT = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Clients.AccountNumber, Persons.FirstName, Persons.LastName, Clients.AccountBalance
                             FROM       Clients INNER JOIN
                             Persons ON Clients.PersonID = Persons.PersonID";



            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DT.Load(Reader);
                }


                Reader.Close();


            }

            catch (Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return DT;
        }
        public static DataTable GetTotalBalances()
        {
            DataTable DT = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"select SUM(Clients.AccountBalance) as TotalBalances
			                 from Clients";



            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DT.Load(Reader);
                }


                Reader.Close();


            }

            catch (Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return DT;
        }

        public static DataTable ShowAllClients()
        {
            DataTable DT = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Clients.ClientID, Clients.AccountNumber, Clients.PinCode, Clients.AccountBalance, Persons.FirstName, Persons.LastName, Persons.Gender, Persons.Email, Persons.PhoneNumber
                             FROM       Clients INNER JOIN
                                            Persons ON Clients.PersonID = Persons.PersonID";
                            



            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DT.Load(Reader);
                }


                Reader.Close();


            }

            catch (Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return DT;
        }


        public static bool Deposit(
            int DepositID,
            int ClientID,
            decimal Amount,
            decimal AccountBalance,
            string AcNumber,
            DateTime DepositDate

            )
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"INSERT INTO Deposits (ClientID, Amount, AccountNumber, DepositDate)
                             VALUES (@ClientID, @Amount,@AccountNumber, @DepositDate);

                             UPDATE Clients
                             SET AccountBalance = AccountBalance + @Amount
                             WHERE ClientID = @ClientID;";



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@AccountNumber", AcNumber);
            Command.Parameters.AddWithValue("@DepositDate", DepositDate);





            int RowsAffected = 0;

            try
            {

                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }


        public static bool Withdraw(
           int WithdrawID,
           int ClientID,
           decimal Amount,
           decimal AccountBalance,
           string AcNumber,
           DateTime WithdrawDate

           )
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"INSERT INTO Withdrawals
                             (ClientID
                             ,Amount
                             ,AccountNumber
                             ,WithdrawDate)
                                VALUES
                             (@ClientID,
                             @Amount * -1,
                             @AccountNumber,
                             @WithdrawDate)
		   
                             UPDATE Clients
                             SET AccountBalance = AccountBalance + @Amount
                             WHERE ClientID = @ClientID";



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@AccountNumber", AcNumber);
            Command.Parameters.AddWithValue("@WithdrawDate", WithdrawDate);





            int RowsAffected = 0;

            try
            {

                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool TransferFromToClients
            (  
            int ClientID_From,
            int ClientID_TO,
           DateTime TransferDate,
           decimal TransferAmount
           
            )
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"INSERT INTO Transactions
           (
            TransactionNumber
           ,ClientID_From
           ,ClientID_TO
           ,TransferDate
           ,TransferAmount
           ,FromAccountBalanceAtTransfer
           ,ToAccountBalanceAtTransfer)
            VALUES
           ( NEWID(),
           @ClientID_From,
           @ClientID_TO,
           @TransferDate,
           @TransferAmount,
           (SELECT AccountBalance FROM Clients WHERE ClientID = @ClientID_From),
           (SELECT AccountBalance FROM Clients WHERE ClientID = @ClientID_TO))
            

		   Update Clients

		   set AccountBalance = AccountBalance - @TransferAmount
		   where ClientID  = @ClientID_From 
		   
		   Update Clients
		   set AccountBalance = AccountBalance + @TransferAmount
		   where ClientID  = @ClientID_TO";

            SqlCommand Command = new SqlCommand(Query, Connection);
            
            Command.Parameters.AddWithValue("@ClientID_From", ClientID_From);

            Command.Parameters.AddWithValue("@ClientID_TO", ClientID_TO);

            Command.Parameters.AddWithValue("@NewID", Guid.NewGuid());

            Command.Parameters.AddWithValue("@TransferDate", TransferDate);

            Command.Parameters.AddWithValue("@TransferAmount", TransferAmount);

            int RowsAffected = 0;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();


                
            }
            catch(Exception ex) 
            {
                return false;
            }
            finally
            {
                Connection.Close();

            }

            return (RowsAffected > 0);

        }


        public static bool RegisterTransferLog
           (
            
            DateTime TransferDate,
           int ClientID_From,
           decimal FromAccountBalance,
           int ClientID_TO,
          decimal ToAccountBalance,
          decimal TransferAmount

           )
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Transactions.TransferDate,(PersonFrom.FirstName + ' ' + PersonFrom.LastName)as FullName, ClientFrom.AccountNumber AS AccoutnNumberSource, Transactions.FromAccountBalanceAtTransfer AS AccountBalanceSourceAtTransfer, Transactions.TransferAmount * - 1 AS TransferAmountFromSource, ClientFrom.AccountBalance AS CurrentBalanceOfTheSourceAccount,(PersonTo.FirstName + ' ' + PersonTo.LastName)as FullName, ClientTo.AccountNumber AS AccoutnNumberDestination, 
                             Transactions.ToAccountBalanceAtTransfer AS AccountBalanceDestinationAtTransfer, Transactions.TransferAmount AS TransferAmountToDestination, ClientTo.AccountBalance AS CurrentBalanceOfTheDestinationAccount



                             FROM       Transactions INNER JOIN
                             Clients AS ClientFrom ON Transactions.ClientID_From = ClientFrom.ClientID INNER JOIN
                             Clients AS ClientTo ON Transactions.ClientID_TO = ClientTo.ClientID INNER JOIN
                             Persons as PersonFrom  ON ClientFrom.PersonID = PersonFrom.PersonID 
			                 INNER JOIN Persons AS PersonTo ON ClientTo.PersonID = PersonTo.PersonID";
                             

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TransferDate", TransferDate);

            Command.Parameters.AddWithValue("@ClientID_From", ClientID_From);

            Command.Parameters.AddWithValue("@FromAccountBalance", FromAccountBalance);

            Command.Parameters.AddWithValue("@ClientID_TO", ClientID_TO);

            Command.Parameters.AddWithValue("@ToAccountBalance", ToAccountBalance);
           
            Command.Parameters.AddWithValue("@TransferAmount", TransferAmount);


            int RowsAffected = 0;

            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Connection.Close();

            }

            return (RowsAffected > 0);

        }

        public static DataTable GetTransferLog()
        {
            DataTable DtTransferLog = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Transactions.TransferDate,(PersonFrom.FirstName + ' ' + PersonFrom.LastName)as SourceFullName, ClientFrom.AccountNumber AS AccoutnNumberSource, Transactions.FromAccountBalanceAtTransfer AS AccountBalanceSourceAtTransfer, Transactions.TransferAmount * - 1 AS TransferAmountFromSource, ClientFrom.AccountBalance AS CurrentBalanceOfTheSourceAccount,(PersonTo.FirstName + ' ' + PersonTo.LastName)as DestinationFullName, ClientTo.AccountNumber AS AccoutnNumberDestination, 
               Transactions.ToAccountBalanceAtTransfer AS AccountBalanceDestinationAtTransfer, Transactions.TransferAmount AS TransferAmountToDestination, ClientTo.AccountBalance AS CurrentBalanceOfTheDestinationAccount

               FROM       Transactions INNER JOIN
               Clients AS ClientFrom ON Transactions.ClientID_From = ClientFrom.ClientID INNER JOIN
               Clients AS ClientTo ON Transactions.ClientID_TO = ClientTo.ClientID INNER JOIN
               Persons as PersonFrom  ON ClientFrom.PersonID = PersonFrom.PersonID 
			   INNER JOIN Persons AS PersonTo ON ClientTo.PersonID = PersonTo.PersonID";



            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DtTransferLog.Load(Reader);
                }


                Reader.Close();


            }

            catch (Exception ex)
            {


            }
            finally
            {
                Connection.Close();
            }


            return DtTransferLog;

        }


        internal class Program
        {

            static void Main(string[] args)
            {

                




               

                Console.ReadKey();



            }
        }
    }
}
