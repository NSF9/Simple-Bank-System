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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void SetUpButton()
        {
            clsButtonStyler.ButtonADUStyler(btnTransfer);
            clsButtonStyler.ButtonADUStyler(btnClose);
            clsButtonStyler.ButtonADUStyler(btnSearch);

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

        private void SetupSenderTextBox()
        {


            txtSender.PlaceholderText = "Sender ID";
           // txtSender.Size = new Size(173, 30); // نفس ارتفاع الباسورد

            txtSender.BorderRadius = 10;
            txtSender.FillColor = Color.WhiteSmoke;
            txtSender.BorderColor = Color.Silver;
            txtSender.BorderThickness = 1;
            txtSender.Font = new Font("Segoe UI", 11);


            txtSender.RightToLeft = RightToLeft.No;
        }

        private void SetupRecipientTextBox()
        {


            txtRecipient.PlaceholderText = "Recipient ID"; // نفس ارتفاع الباسورد

            txtRecipient.BorderRadius = 10;
            txtRecipient.FillColor = Color.WhiteSmoke;
            txtRecipient.BorderColor = Color.Silver;
            txtRecipient.BorderThickness = 1;
            txtRecipient.Font = new Font("Segoe UI", 11);


            txtRecipient.RightToLeft = RightToLeft.No;
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
            




            SetupSenderTextBox();
            SetupRecipientTextBox();



            //////////////////////
            ///

            SetupFirstNameTextBoxReciver();
            SetupLastNameTextBoxReciver();
            SetupGenderTextBoxReciver();
            SetupPhoneTextBoxReciver();
            SetupEmailTextBoxReciver();
            SetupPinCodeTextBoxReciver();
            SetupAccountBalanceTextBoxReciver();



        }
        private void SetupFirstNameTextBoxReciver()
        {
            txtFirstNameReceiver.Focus();
            txtFirstNameReceiver.PlaceholderText = "First name";
            txtFirstNameReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtFirstNameReceiver.BorderRadius = 10;
            txtFirstNameReceiver.FillColor = Color.WhiteSmoke;
            txtFirstNameReceiver.BorderColor = Color.Silver;
            txtFirstNameReceiver.BorderThickness = 1;
            txtFirstNameReceiver.Font = new Font("Segoe UI", 11);

            txtFirstNameReceiver.Enabled = false;

            txtFirstNameReceiver.RightToLeft = RightToLeft.No;
        }

        private void SetupLastNameTextBoxReciver()
        {

            txtLastNameReceiver.PlaceholderText = "Last Name";
            txtLastNameReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد
            txtLastNameReceiver.BorderRadius = 10;
            txtLastNameReceiver.FillColor = Color.WhiteSmoke;
            txtLastNameReceiver.BorderColor = Color.Silver;
            txtLastNameReceiver.BorderThickness = 1;
            txtLastNameReceiver.Font = new Font("Segoe UI", 11);
            txtLastNameReceiver.Enabled = false;
            txtLastNameReceiver.RightToLeft = RightToLeft.No;
        }
        private void SetupEmailTextBoxReciver()
        {


            txtEmailReceiver.PlaceholderText = "Email";
            txtEmailReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد
            txtEmailReceiver.BorderRadius = 10;
            txtEmailReceiver.FillColor = Color.WhiteSmoke;
            txtEmailReceiver.BorderColor = Color.Silver;
            txtEmailReceiver.BorderThickness = 1;
            txtEmailReceiver.Font = new Font("Segoe UI", 11);
            txtEmailReceiver.Enabled = false;
            txtEmailReceiver.RightToLeft = RightToLeft.No;
        }
        private void SetupGenderTextBoxReciver()
        {


            txtGenderReceiver.PlaceholderText = "Gender";
            txtGenderReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد
            txtGenderReceiver.BorderRadius = 10;
            txtGenderReceiver.FillColor = Color.WhiteSmoke;
            txtGenderReceiver.BorderColor = Color.Silver;
            txtGenderReceiver.BorderThickness = 1;
            txtGenderReceiver.Font = new Font("Segoe UI", 11);
            txtGenderReceiver.Enabled = false;
            txtGenderReceiver.RightToLeft = RightToLeft.No;
        }

        private void SetupPhoneTextBoxReciver()
        {


            txtPhoneReceiver.PlaceholderText = "Phone Number";
            txtPhoneReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtPhoneReceiver.BorderRadius = 10;
            txtPhoneReceiver.FillColor = Color.WhiteSmoke;
            txtPhoneReceiver.BorderColor = Color.Silver;
            txtPhoneReceiver.BorderThickness = 1;
            txtPhoneReceiver.Font = new Font("Segoe UI", 11);

            txtPhoneReceiver.Enabled = false;

            txtPhoneReceiver.RightToLeft = RightToLeft.No;
        }
        private void SetupPinCodeTextBoxReciver()
        {


            txtPINCodeReceiver.PlaceholderText = "Pin code";
            txtPINCodeReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtPINCodeReceiver.BorderRadius = 10;
            txtPINCodeReceiver.FillColor = Color.WhiteSmoke;
            txtPINCodeReceiver.BorderColor = Color.Silver;
            txtPINCodeReceiver.BorderThickness = 1;
            txtPINCodeReceiver.Font = new Font("Segoe UI", 11);

            txtPINCodeReceiver.Enabled = false;

            txtPINCodeReceiver.RightToLeft = RightToLeft.No;
        }
        private void SetupAccountBalanceTextBoxReciver()
        {


            txtAccountBalanceReceiver.PlaceholderText = "Account Balance";
            txtAccountBalanceReceiver.Size = new Size(320, 30); // نفس ارتفاع الباسورد

            txtAccountBalanceReceiver.BorderRadius = 10;
            txtAccountBalanceReceiver.FillColor = Color.WhiteSmoke;
            txtAccountBalanceReceiver.BorderColor = Color.Silver;
            txtAccountBalanceReceiver.BorderThickness = 1;
            txtAccountBalanceReceiver.Font = new Font("Segoe UI", 11);

            txtAccountBalanceReceiver.Enabled = false;

            txtAccountBalanceReceiver.RightToLeft = RightToLeft.No;
        }
     
        private void SetupPanelStyle()
        {
            TransferPanel.BorderRadius = 1;
            TransferPanel.FillColor = Color.DarkGray;
            TransferPanel.BorderColor = Color.FromArgb(220, 220, 220);
            TransferPanel.BorderThickness = 1;


            TransferPanel.ShadowDecoration.Enabled = true;
            TransferPanel.ShadowDecoration.Color = Color.Gray;
            TransferPanel.ShadowDecoration.Depth = 10;
            TransferPanel.ShadowDecoration.Shadow = new Padding(5);


        }

        clsClients _SenderID;
        clsClients _Receiver;
        private bool FindSender()
        {

            ErrorProvider errorProviderSender = new ErrorProvider();

            errorProviderSender.Clear();
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtSender.Text))
            {
                errorProviderSender.SetError(txtSender, "Required");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _SenderID = clsClients.Find(txtSender.Text);



            if (_SenderID != null)
            {
                SenderAcc.Text = _SenderID.AccountNumber;
                txtFirstName.Text = _SenderID.FirstName;
                txtLastName.Text = _SenderID.LastName;
                txtGender.Text = _SenderID.Gender;
                txtEmail.Text = _SenderID.Email;
                txtPhoneNumber.Text = _SenderID.PhoneNumber;
                txtPinCode.Text = _SenderID.PinCode;
                txtAccountBalance.Text = _SenderID.AccountBalance.ToString();
                return true;


            }
            else
            {
                return false;
            }
           

           
        }


        private bool FindReceiver()
        {
            ErrorProvider errorProviderReciver = new ErrorProvider();

            errorProviderReciver.Clear();
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtRecipient.Text))
            {
                errorProviderReciver.SetError(txtRecipient, "Required");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _Receiver = clsClients.Find(txtRecipient.Text);



            if (_Receiver != null)
            {
                ReceiverAcc.Text = _Receiver.AccountNumber;
                txtFirstNameReceiver.Text = _Receiver.FirstName;
                txtLastNameReceiver.Text = _Receiver.LastName;
                lbGenderReceiver.Text = _Receiver.Gender;
                txtEmailReceiver.Text = _Receiver.Email;
                txtPhoneReceiver.Text = _Receiver.PhoneNumber;
                txtPINCodeReceiver.Text = _Receiver.PinCode;
                txtAccountBalanceReceiver.Text = _Receiver.AccountBalance.ToString();

                return true;
            }
            else
            {
                return false;
            }

        }

        private bool MakeTransfer()
        {
            ErrorProvider errorProviderAmount = new ErrorProvider();

            errorProviderAmount.Clear();
            bool isValid = true;





            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProviderAmount.SetError(txtAmount, "Required");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please enter an amount", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal Amount = Convert.ToDecimal(txtAmount.Text);

            if (_SenderID.AccountNumber != null && _Receiver.AccountNumber != null)

            {

                return _SenderID.AddTransactionsDetails(_SenderID.ClientID, _Receiver.ClientID, Amount);

            }
            else
            {
                return false;
            }
        
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            SetupPanelStyle();
            txtBoxSetUp();
            SetUpButton();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool SenderIsFind = FindSender();

            bool ReceiverIsFind = FindReceiver();


            if(!SenderIsFind && ! ReceiverIsFind)
            {
                MessageBox.Show("No Clients found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (SenderIsFind)
            {

                FindSender();

            }
            else
            {
                MessageBox.Show("Sender not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ReceiverIsFind)
            {
                FindReceiver();
            }
        
            else
            {
                MessageBox.Show("Receiver not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
       
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            
            if (MakeTransfer())
            {
                MessageBox.Show("Transferred completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FindSender();
                FindReceiver();

            }
            
        }
    }
}
