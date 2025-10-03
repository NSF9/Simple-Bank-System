using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class ctrlAddNewClient : UserControl
    {
        public ctrlAddNewClient()
        {
            InitializeComponent();
        }

        private void ctrlAddNewClient_Load(object sender, EventArgs e)
        {

        }

        private void SetupFirstNameTextBox()
        {
            txtFirstName.Focus();
            txtFirstName.PlaceholderText = "First name";
            txtFirstName.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtFirstName.BorderRadius = 10;
            txtFirstName.FillColor = Color.WhiteSmoke;
            txtFirstName.BorderColor = Color.Silver;
            txtFirstName.BorderThickness = 1;
            txtFirstName.Font = new Font("Segoe UI", 11);


            txtFirstName.RightToLeft = RightToLeft.No;
        }

        private void SetupLastNameTextBox()
        {

            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtLastName.BorderRadius = 10;
            txtLastName.FillColor = Color.WhiteSmoke;
            txtLastName.BorderColor = Color.Silver;
            txtLastName.BorderThickness = 1;
            txtLastName.Font = new Font("Segoe UI", 11);


            txtLastName.RightToLeft = RightToLeft.No;
        }
        private void SetupEmailTextBox()
        {


            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtEmail.BorderRadius = 10;
            txtEmail.FillColor = Color.WhiteSmoke;
            txtEmail.BorderColor = Color.Silver;
            txtEmail.BorderThickness = 1;
            txtEmail.Font = new Font("Segoe UI", 11);


            txtEmail.RightToLeft = RightToLeft.No;
        }
        private void SetupGenderTextBox()
        {


            txtGender.PlaceholderText = "Gender";
            txtGender.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtGender.BorderRadius = 10;
            txtGender.FillColor = Color.WhiteSmoke;
            txtGender.BorderColor = Color.Silver;
            txtGender.BorderThickness = 1;
            txtGender.Font = new Font("Segoe UI", 11);


            txtGender.RightToLeft = RightToLeft.No;
        }

        private void SetupPhoneTextBox()
        {


            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtPhoneNumber.BorderRadius = 10;
            txtPhoneNumber.FillColor = Color.WhiteSmoke;
            txtPhoneNumber.BorderColor = Color.Silver;
            txtPhoneNumber.BorderThickness = 1;
            txtPhoneNumber.Font = new Font("Segoe UI", 11);


            txtPhoneNumber.RightToLeft = RightToLeft.No;
        }
        private void SetupPinCodeTextBox()
        {


            txtPinCode.PlaceholderText = "Pin code";
            txtPinCode.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtPinCode.BorderRadius = 10;
            txtPinCode.FillColor = Color.WhiteSmoke;
            txtPinCode.BorderColor = Color.Silver;
            txtPinCode.BorderThickness = 1;
            txtPinCode.Font = new Font("Segoe UI", 11);


            txtPinCode.RightToLeft = RightToLeft.No;
        }
        private void SetupAccountBalanceTextBox()
        {


            txtAccountBalance.PlaceholderText = "Account Balance";
            txtAccountBalance.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtAccountBalance.BorderRadius = 10;
            txtAccountBalance.FillColor = Color.WhiteSmoke;
            txtAccountBalance.BorderColor = Color.Silver;
            txtAccountBalance.BorderThickness = 1;
            txtAccountBalance.Font = new Font("Segoe UI", 11);


            txtAccountBalance.RightToLeft = RightToLeft.No;
        }
        private void txtBoxSetUp()
        {
            SetupFirstNameTextBox();
            SetupLastNameTextBox();
            SetupGenderTextBox();
            SetupPhoneTextBox();
            SetupEmailTextBox();
            SetupPinCodeTextBox();
            SetupAccountBalanceTextBox();
        }
    }
}
