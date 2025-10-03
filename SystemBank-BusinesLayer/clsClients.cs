using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;
using FirstBankProject;
using SimpleSystemBank;
using SystemBankBusinesLayer;

namespace SystemBankBusinessLayer
{

    public class clsClients : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ClientID { get; private set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public decimal AccountBalance { get; set; }

        public int DepositID { get; private set; }
        public int WithdrawID { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public decimal FromAccountBalance { get; set; }

        public decimal ToAccountBalance { get; set; }



        public clsClients()
        {
            this.ClientID = -1;
            this.AccountNumber = "";
            this.PinCode = "";
            this.AccountBalance = 0;
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = "";
            this.Email = "";
            this.PhoneNumber = "";

            Mode = enMode.AddNew;

        }

        private clsClients(

            int ClientID,
            string accountNumber,
            string password,
            decimal accountBalance,
            int personID,
            string firsrname,
            string lastname,
            string Gender,
            string email,
            string phonenumber
            )
        {
            this.ClientID = ClientID;
            this.AccountNumber = accountNumber;
            this.PinCode = password;
            this.AccountBalance = accountBalance;
            this.PersonID = personID;
            this.FirstName = firsrname;
            this.LastName = lastname;
            this.Gender = Gender;
            this.Email = email;
            this.PhoneNumber = phonenumber;

            Mode = enMode.Update;

        }


        private clsClients(string accoountnumber)
        {  
            this.AccountNumber = accoountnumber;
         
            Mode = enMode.Update;
        }

        public static clsClients Find(int ClientID)
        {
            string AccountNumber = "", 
                PinCode = "",
                FirstName = "",
                LastName = "",
                Gender = "",
                Email = "",
                PhoneNumber = "";

            decimal AccountBalance = 0;

            int PersonID = 0;
       

            if (clsClientsDataAccess.GetClientByClientID(
                 ClientID,
                ref AccountNumber,
                ref PinCode,
                ref AccountBalance,
                ref PersonID,
                ref FirstName,
                ref LastName,
                ref Gender,
                ref Email,
                ref PhoneNumber))

                return new clsClients(ClientID, AccountNumber, PinCode, AccountBalance,
                    PersonID, FirstName, LastName,Gender, Email, PhoneNumber);
            else
                return null;
        }
        public static clsClients Find(string AccountNumber)
        {
            string
                PinCode = "",
                FirstName = "",
                LastName = "",
                Gender = "",
                Email = "",
                PhoneNumber = "";

            decimal AccountBalance = 0;

            int PersonID = 0, ClientID = 0;


            if (clsClientsDataAccess.GetClientByAccNumber(
               ref ClientID,
                 AccountNumber,
                ref PinCode,
                ref AccountBalance,
                ref PersonID,
                ref FirstName,
                ref LastName,
                ref Gender,
                ref Email,
                ref PhoneNumber))

                return new clsClients(ClientID, AccountNumber, PinCode, AccountBalance,
                    PersonID, FirstName, LastName, Gender, Email, PhoneNumber);
            else
                return null;
        }
        public static clsClients FindLastClient()
        {
            string AccountNumber = "";

            if (clsClientsDataAccess.FindLastClient(ref AccountNumber))



                return new clsClients(AccountNumber);

            else
                return null;
        }
        private bool _AddNewClient()
        {
            this.ClientID = clsClientsDataAccess.AddNewClient(
               this.AccountNumber,
                this.PinCode,
                this.AccountBalance,
                this.PersonID,
                this.FirstName,
                this.LastName,
                this.Gender,
                this.Email,
                this.PhoneNumber);

            return (this.ClientID != -1);



        }

        private bool _UpdateClient()
        {
            return clsClientsDataAccess.UpdateClient(this.ClientID, this.AccountNumber,
                this.PinCode,
                this.AccountBalance,
                this.PersonID,
                this.FirstName,
                this.LastName,
                this.Gender,
                this.Email,
                this.PhoneNumber);
        }

        public bool DeleteClient(int ClientID)
        {
            return clsClientsDataAccess.DeleteClient(ClientID);

        }
        public bool Save()
        {


            switch (Mode)
            {


                case enMode.AddNew:

                    if (_AddNewClient())
                    {

                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateClient();


            }
            return false;

        }

        private bool AddDepositDetails(decimal Amount)
        {

            return clsClientsDataAccess.Deposit(this.DepositID, this.ClientID, Amount, this.AccountBalance, this.AccountNumber, this.TransactionDate = DateTime.Now);
        }
        private bool AddWithdrawDetails(decimal Amount)
        {

            return clsClientsDataAccess.Withdraw(this.WithdrawID, this.ClientID, Amount, this.AccountBalance, this.AccountNumber, this.TransactionDate = DateTime.Now);
        }
        public bool AddTransactionsDetails(
            int ClientID_From,
            int ClientID_To,
            decimal Amount
            )
        {
            if (Amount > this.AccountBalance)
            {
                return false;
            }
            else
            {
                return clsClientsDataAccess.TransferFromToClients(ClientID_From, ClientID_To, TransactionDate = DateTime.Now, Amount);
                GetTransferLog();
            }
            return true;



        }

        private bool GetTransferLog()
        {
            TransactionDate = DateTime.Now;
           int  ClientID_From = 0;
            int ClientID_TO = 0;
            decimal TransferAmount = 0;

            return clsClientsDataAccess.RegisterTransferLog(TransactionDate, ClientID_From, FromAccountBalance, ClientID_TO, ToAccountBalance, TransferAmount);
        }

        public void Deposit(decimal Amount)
        {
            this.AccountBalance += Amount;

            AddDepositDetails(Amount);

            Save();
        }

        public bool Withdraw(decimal Amount)
        {
            if (Amount > this.AccountBalance)
            {
                return false;
            }
            else
            {
                this.AccountBalance -= Amount;
                AddWithdrawDetails(Amount);
                Save();
            }

            return true;

        }

        public static DataTable GetTotalClients()
        {
            return clsClientsDataAccess.GetTotalClients();
        }

        public static DataTable GetTotalBalances()
        {
            return clsClientsDataAccess.GetTotalBalances();
        }

        public static DataTable ShowAllClients()
        {
            return clsClientsDataAccess.ShowAllClients();
        }

        public static DataTable ShowAllTransferLog()
        {
            return clsClientsDataAccess.GetTransferLog();
        }

        static void Main(string[] args)
        {


        }
    }
}
