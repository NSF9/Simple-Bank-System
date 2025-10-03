using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankBusinessLayer;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class frmWithdrawal : Form
    {
        clsClients _Client;
        public frmWithdrawal(clsClients Client, int _SelectedIDClient)
        {
            InitializeComponent();
            _Client = Client;

            ClientIDLable.Text = _Client.ClientID.ToString();
            txtFirstName.Text = _Client.FirstName;
            txtLastName.Text = _Client.LastName;
            txtGender.Text = _Client.Gender;
            txtEmail.Text = _Client.Email;
            txtPhoneNumber.Text = _Client.PhoneNumber;
            txtPinCode.Text = _Client.PinCode;
            txtAccountBalance.Text = _Client.AccountBalance.ToString();
        }

        private void SetUpButton()
        {
            clsButtonStyler.ButtonADUStyler(btnWithdrawal);
            clsButtonStyler.ButtonADUStyler(btnClose);


        }
        private void SetupPanelStyle()
        {
            WithdrawalPanel.BorderRadius = 1;
            WithdrawalPanel.FillColor = Color.DarkGray;
            WithdrawalPanel.BorderColor = Color.FromArgb(220, 220, 220);
            WithdrawalPanel.BorderThickness = 1;


            WithdrawalPanel.ShadowDecoration.Enabled = true;
            WithdrawalPanel.ShadowDecoration.Color = Color.Gray;
            WithdrawalPanel.ShadowDecoration.Depth = 10;
            WithdrawalPanel.ShadowDecoration.Shadow = new Padding(5);


        }
        private void SetupFirstNameTextBox()
        {
            txtFirstName.Focus();
            txtFirstName.PlaceholderText = "First name";
            txtFirstName.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtFirstName.BorderRadius = 10;
            txtFirstName.FillColor = Color.WhiteSmoke;
            txtFirstName.BorderColor = Color.Silver;
            txtFirstName.BorderThickness = 1;
            txtFirstName.Font = new Font("Segoe UI", 11);

            txtFirstName.Enabled = false;

            txtFirstName.RightToLeft = RightToLeft.No;
        }

        private void SetupLastNameTextBox()
        {

            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtLastName.BorderRadius = 10;
            txtLastName.FillColor = Color.WhiteSmoke;
            txtLastName.BorderColor = Color.Silver;
            txtLastName.BorderThickness = 1;
            txtLastName.Font = new Font("Segoe UI", 11);

            txtLastName.Enabled = false;

            txtLastName.RightToLeft = RightToLeft.No;
        }
        private void SetupEmailTextBox()
        {


            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtEmail.BorderRadius = 10;
            txtEmail.FillColor = Color.WhiteSmoke;
            txtEmail.BorderColor = Color.Silver;
            txtEmail.BorderThickness = 1;
            txtEmail.Font = new Font("Segoe UI", 11);

            txtEmail.Enabled = false;


            txtEmail.RightToLeft = RightToLeft.No;
        }
        private void SetupGenderTextBox()
        {


            txtGender.PlaceholderText = "Gender";
            txtGender.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtGender.BorderRadius = 10;
            txtGender.FillColor = Color.WhiteSmoke;
            txtGender.BorderColor = Color.Silver;
            txtGender.BorderThickness = 1;
            txtGender.Font = new Font("Segoe UI", 11);

            txtGender.Enabled = false;

            txtGender.RightToLeft = RightToLeft.No;
        }

        private void SetupPhoneTextBox()
        {


            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtPhoneNumber.BorderRadius = 10;
            txtPhoneNumber.FillColor = Color.WhiteSmoke;
            txtPhoneNumber.BorderColor = Color.Silver;
            txtPhoneNumber.BorderThickness = 1;
            txtPhoneNumber.Font = new Font("Segoe UI", 11);

            txtPhoneNumber.Enabled = false;

            txtPhoneNumber.RightToLeft = RightToLeft.No;
        }
        private void SetupPinCodeTextBox()
        {


            txtPinCode.PlaceholderText = "Pin code";
            txtPinCode.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtPinCode.BorderRadius = 10;
            txtPinCode.FillColor = Color.WhiteSmoke;
            txtPinCode.BorderColor = Color.Silver;
            txtPinCode.BorderThickness = 1;
            txtPinCode.Font = new Font("Segoe UI", 11);

            txtPinCode.Enabled = false;

            txtPinCode.RightToLeft = RightToLeft.No;
        }
        private void SetupAccountBalanceTextBox()
        {


            txtAccountBalance.PlaceholderText = "Account Balance";
            txtAccountBalance.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtAccountBalance.BorderRadius = 10;
            txtAccountBalance.FillColor = Color.WhiteSmoke;
            txtAccountBalance.BorderColor = Color.Silver;
            txtAccountBalance.BorderThickness = 1;
            txtAccountBalance.Font = new Font("Segoe UI", 11);

            txtAccountBalance.Enabled = false;

            txtAccountBalance.RightToLeft = RightToLeft.No;
        }
        private void SetupAmountTextBox()
        {


            txtAmount.PlaceholderText = "Amount";
            txtAmount.Size = new Size(173, 30); // نفس ارتفاع الباسورد

            txtAmount.BorderRadius = 10;
            txtAmount.FillColor = Color.WhiteSmoke;
            txtAmount.BorderColor = Color.Silver;
            txtAmount.BorderThickness = 1;
            txtAmount.Font = new Font("Segoe UI", 11);


            txtAmount.RightToLeft = RightToLeft.No;
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
            SetupAmountTextBox();
        }
        private void DepositPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhoneNumber_Load(object sender, EventArgs e)
        {
            
        }
        private bool Withdrawal()
        {

            ErrorProvider errorProvider1 = new ErrorProvider();

            errorProvider1.Clear();
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "Required");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            decimal NewAmount = Convert.ToDecimal(txtAmount.Text);


            if (NewAmount > 0)
            {
                return _Client.Withdraw(NewAmount);
            }
            else
            {
                MessageBox.Show("Please enter positive amount.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
               
            }
        }
        private void frmWithdrawal_Load(object sender, EventArgs e)
        {
            txtBoxSetUp();
            SetUpButton();
            SetupPanelStyle();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            bool result = Withdrawal();

            if (result)
            {
                MessageBox.Show("Withdrawal completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {

                MessageBox.Show("The process failed. Please check the amount and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
            }
        }
    }
}
