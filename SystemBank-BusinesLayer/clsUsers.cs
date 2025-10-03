using FirstBankProject;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;
using static SystemBankBusinesLayer.clsUsers;


namespace SystemBankBusinesLayer
{

    public class clsUsers : clsPerson
    {

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Passowrd { get; set; }
        public int Permission { get; set; }


        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public enum enLogIntype { LogIn = 1, LogOut = 2 }




        public enum enPermission
        {
            eAll = -1,
            pListClients = 1,
            pAddNewClient = 2,
            pDeleteClient = 4,
            pUpdateClient = 8,
            pFindClient = 16,
            pTranactions = 32,
            pManagingUsers = 64,
            pShowLogInRegister = 128,
        }



        public int AddPermissions()
        {
            Permission = 0;
            string Answers = "n";



            Console.WriteLine("Do you Want Give All Permission? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.eAll;
                
                return Permission;

            }

            Console.WriteLine("Do you Want Give Lists Clients? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pListClients;
            }

            Console.WriteLine("Do you Want Give  Add New Client? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pAddNewClient;
            }

            Console.WriteLine("Do you Want Give  Delete Client? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pDeleteClient;
            }

            Console.WriteLine("Do you Want Give  Update Client? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pUpdateClient;
            }

            Console.WriteLine("Do you Want Give  Find Client? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pFindClient;
            }

            Console.WriteLine("Do you Want Give  Tranactions? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pTranactions;
            }

            Console.WriteLine("Do you Want Give  Managing Users? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pManagingUsers;
            }

            Console.WriteLine("Do you Want Give  Show LogIn Register ? ");
            Answers = Console.ReadLine();

            if (Answers == "Y" || Answers == "y")
            {
                Permission += (int)enPermission.pShowLogInRegister;
            }
            return Permission;
        }

       
        public bool CheckAccessPermission(enPermission permission)
        {
            if (this.Permission == (int)enPermission.eAll)
                return true;

            if (((int)permission & this.Permission) == (int)permission)
                return true;
            else
                return false;
        }

        public clsUsers()
        {
            this.UserID = -1;
            this.Username = "";
            this.Passowrd = "";
            this.Permission = 0;
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = "";
            this.Email = "";
            this.PhoneNumber = "";

            this.Mode = enMode.AddNew;
        }

        private clsUsers
            (
            int userID,
            string username, 
            string password,
            int permission, 
            int personid, 
            string firstname,
            string lastname,
            string gender,
            string email, 
            string phonenumber
            
            
            
            )
        {
            UserID = userID;
            Username = username;
            Passowrd = password;
            Permission = permission;
            PersonID = personid;  
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Email = email;
            PhoneNumber = phonenumber;


            Mode = enMode.Update;



        }

        private clsUsers(string username)
        {

            Username = username;

            Mode = enMode.Update;



        }

        private clsUsers(int permission)
        {

            Permission = permission;

            Mode = enMode.Update;
        }


        

        public static clsUsers Find(string username)
        {
            int userID = -1, permission = 0, personid = 1;

            string password = "", firstname = "", lastname = "",gender = "", email = "", phonenumber = "";


            if (clsUsersDataAccess.GetUserByAccountNumber(ref firstname, ref lastname, ref gender,ref email, ref phonenumber,
               ref userID, username, ref password, ref permission, ref personid))

                return new clsUsers(userID,
             username,
             password,
             permission,
             personid,
             firstname,
             lastname,
             gender,
             email,
             phonenumber);

            else return null;

        }
        public static clsUsers Find(int userID)
        {
            int permission = 0, personid = 0;

            string username = "", password = "", firstname = "", lastname = "", gender = "", email = "", phonenumber = "";


            if (clsUsersDataAccess.GetUserByUserID(ref firstname, ref lastname, ref gender, ref email, ref phonenumber,
                userID, ref username, ref password, ref permission, ref personid))

                return new clsUsers(userID,
             username,
             password,
             permission,
             personid,
             firstname,
             lastname,
             gender,
             email,
             phonenumber);

            else return null;

        }
        public static clsUsers Find(string username, string Password)
        {

            int userID = -1, permission = 0, personid = 1;

            string password = "", firstname = "", lastname = "", gender = "", email = "", phonenumber = "";



            if (clsUsersDataAccess.GetUserByAccountNumber(ref firstname, ref lastname, ref gender,ref email, ref phonenumber,
                           ref userID, username, ref password, ref permission, ref personid))

                return new clsUsers(userID,
             username,
             password,
             permission,
             personid,
             firstname,
             lastname,
             gender,
             email,
             phonenumber);

            else return null;

        }
        public static clsUsers FindLastUser()
        {
            string Username = "";


            if (clsUsersDataAccess.GetLastUsername(ref Username))

                return new clsUsers(Username);

            else return null;

        }

        public static clsUsers FindPermission(int UserID)
        {
            int Permission = -1;


            if (clsUsersDataAccess.RetrivePermissions(UserID,Permission))

                return new clsUsers(Permission);

            else return null;

        }
        
        private bool _AddNewUser()
        {

            this.UserID = clsUsersDataAccess.AddNewUser(this.FirstName, this.LastName,this.Gender, this.Email, this.PhoneNumber,
                this.Username, this.Passowrd, this.Permission, this.PersonID);


            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {

            return clsUsersDataAccess.UpdateUser(this.FirstName, this.LastName, this.Gender, this.Email, this.PhoneNumber,
             this.UserID, this.Username, this.Passowrd, this.Permission, this.PersonID);

        }
        public static bool DeleteUser(int UserID)
        {
            return clsUsersDataAccess.DeleteUser(UserID);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:

                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;

                    }

                    case enMode.Update:

                    return _UpdateUser();

            }

            return false;   
        }


        public static DataTable ShowAllUsers()
        {
            return clsUsersDataAccess.ShowAllUsers();
        }

        public static DataTable ShowAllLogRegister()
        {
            return clsUsersDataAccess.ShowAllLogRegister();
        }

        public bool SaveRegister(int UserID, int LogTypeID)
        {
            if (LogTypeID == (int)enLogIntype.LogIn)
            {
                return clsLogRegisterDA.SaveLogRegister(UserID, (int)enLogIntype.LogIn);
            }
            else if (LogTypeID == (int)enLogIntype.LogOut)
            {
                return clsLogRegisterDA.SaveLogRegister(UserID, (int)enLogIntype.LogOut);
            }

            throw new ArgumentException("Invalid LogTypeID passed to SaveRegister.");
        }

      




    }
}
