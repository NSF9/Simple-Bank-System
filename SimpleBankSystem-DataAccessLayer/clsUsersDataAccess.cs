using System;
using System.Data;
using System.Data.SqlClient;


namespace FirstBankProject
{
    
    public class clsUsersDataAccess 
    {



        public static bool GetUserByAccountNumber(
   
            ref string FirstName,
            ref string LastName,
            ref string Gender,
            ref string Email,
            ref string Phonenumber,
            ref int UserID , 
            string Username,
            ref string Passowrd,
            ref int Permission,
            ref int    PersonID)


           
        {

            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Persons.*, Users.*
                            FROM       Persons INNER JOIN
                            Users ON Persons.PersonID = Users.PersonID
			                where Username = @Username";


            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@Username",Username);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Gender = (string)Reader["Gender"];
                    Email = (string)Reader["Email"];
                    Phonenumber = (string)Reader["Phonenumber"];
                    UserID = (int)Reader["UserID"];
                    Username = (string)Reader["Username"];
                    Passowrd = (string)Reader["Password"];

                    Permission = (int)Reader["Permission"];
                    PersonID = (int)Reader["PersonID"];

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
                    
            }

            finally
            {
                Connection.Close();

            }

            return IsFound;

        }

        public static bool GetUserByUserID(

            ref string FirstName,
            ref string LastName,
            ref string Gender,
            ref string Email,
            ref string Phonenumber,
             int UserID,
           ref string Username,
            ref string Passowrd,
            ref int Permission,
            ref int PersonID)



        {

            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT    Persons.*, Users.*
                            FROM       Persons INNER JOIN
                            Users ON Persons.PersonID = Users.PersonID
			                where UserID = @UserID";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Gender = (string)Reader["Gender"];
                    Email = (string)Reader["Email"];
                    Phonenumber = (string)Reader["Phonenumber"];
                    UserID = (int)Reader["UserID"];
                    Username = (string)Reader["Username"];
                    Passowrd = (string)Reader["Password"];

                    Permission = (int)Reader["Permission"];
                    PersonID = (int)Reader["PersonID"];

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;

            }

            finally
            {
                Connection.Close();

            }

            return IsFound;

        }
        public static bool GetUsernameAndPassword
           (ref int userID,
            string Username,
            string Passowrd)
        {





            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"select Users.UserID, Users.Username, Users.Password from Users";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Passowrd", Passowrd);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.Read())
                {
                    IsFound = true;

                    userID = (int)Reader["UserID"];



                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;

            }

            finally
            {
                Connection.Close();

            }

            return IsFound;

        }

        public static bool GetLastUsername(ref string Username)
        {

            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"SELECT TOP 1 Username
                           FROM Users
                           ORDER BY UserID DESC";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Username", Username);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.Read())
                {
                    IsFound = true;
        
                    Username = (string)Reader["Username"];
                    

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;

            }

            finally
            {
                Connection.Close();

            }

            return IsFound;

        }

        public static bool RetrivePermissions(int UserID,int Permission)
        {

            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"select Users.Permission from users
	                         where @UserID = UserID;";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.Read())
                {
                    IsFound = true;

                    Permission = Convert.ToInt32(Reader["Permission"]);

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;

            }

            finally
            {
                Connection.Close();

            }

            return IsFound;

        }
        public static int AddNewUser
             (string FirstName,
             string LastName,
             string Gender,
             string Email,
           string Phonenumber,

            string Username,
             string Passowrd,
             int Permission,
             int PersonID)
        {



            int UserID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);



            string Query = @"insert into Persons(FirstName, LastName,Gender, Email, PhoneNumber) 
                 values(@FirtstName, @LastName,@Gender, @Email,@PhoneNumber)
                 insert into Users(Username, Password, Permission, PersonID)  
                 values( @Username, @Password ,@Permission, (select top 1 SCOPE_IDENTITY() from Persons )) 
                select top 1 SCOPE_IDENTITY() from Users;";


            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@FirtstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@PhoneNumber", Phonenumber);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Passowrd);
            Command.Parameters.AddWithValue("@Permission", Permission);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();


                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();

            }
            return UserID;

        }

        public static bool UpdateUser(
             string FirstName,
             string LastName,
             string Gender,
             string Email,
             string Phonenumber,
             int UserID,
            string Username,
            string Passowrd,
            int Permission,
            int PersonID
            )
        {
            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"UPDATE Users SET Username = @Username, Password = @Password, Permission = @Permission WHERE UserID = @UserID;
               UPDATE Persons SET FirstName = @FirstName, LastName = @LastName,Gender = @Gender, Email = @Email, Phonenumber = @Phonenumber WHERE PersonID = @PersonID;";


            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phonenumber", Phonenumber);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Passowrd);
            Command.Parameters.AddWithValue("@Permission", Permission);

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

        public static bool DeleteUser(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"Delete Users from Users where UserID = @UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
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

        public static DataTable ShowAllUsers()
        {
            DataTable DTAllusers = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @" SELECT  Users.UserID,  Persons.FirstName + ' ' + Persons.LastName as FullName,Persons.Gender, Persons.Email, Persons.PhoneNumber, Users.Username, Users.Password, Users.Permission
                              FROM       Persons INNER JOIN
	                          Users ON Persons.PersonID = Users.PersonID";
             



            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DTAllusers.Load(Reader);
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


            return DTAllusers;
        }

        public static DataTable ShowAllLogRegister()
        {
            DataTable AllLogRegister = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @" SELECT    LogRegister.LogID,Users.Username, Users.Password, Users.Permission, LogType.LogTypeName,LogRegister.LogTime
                              FROM       LogRegister INNER JOIN
                              LogType ON LogRegister.LogTypeID = LogType.LogTypeID INNER JOIN
                              Users ON LogRegister.UserID = Users.UserID";




            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    AllLogRegister.Load(Reader);
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


            return AllLogRegister;
        }

    }
}
