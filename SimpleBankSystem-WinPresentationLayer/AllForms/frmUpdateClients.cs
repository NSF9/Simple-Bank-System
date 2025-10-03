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
    public partial class frmUpdateClients : Form
    {
        public frmUpdateClients(clsClients Client)
        {
            InitializeComponent();
          
            IDClientSent = Client.ClientID;
            ClientIDLable.Text  =IDClientSent.ToString();
            txtFirstName.Text = Client.FirstName;
            txtLastName.Text = Client.LastName;
            txtGender.Text = Client.Gender;
            txtEmail.Text = Client.Email;
            txtPhoneNumber.Text = Client.PhoneNumber;
            txtPinCode.Text = Client.PinCode;
            txtAccountBalance.Text = Client.AccountBalance.ToString();

        }

        private int IDClientSent = 0;
       

        private void frmUpdateClients_Load(object sender, EventArgs e)
        {
            SetUpUpdateClientPanel();
            txtBoxSetUp();
            SetUpAllButtons();
        }
        private void SetupButton(Guna.UI2.WinForms.Guna2Button btn)
        {

            btn.Height = 50;
            btn.Margin = new Padding(10, 10, 10, 0); // (يسار، أعلى، يمين، أسفل)
            btn.BorderRadius = 10;
            btn.Font = new Font("Segoe UI", 11);
            btn.FillColor = Color.DodgerBlue;
            btn.ForeColor = Color.White;
            btn.HoverState.FillColor = Color.FromArgb(0, 90, 200);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = HorizontalAlignment.Center;
            btn.ImageAlign = HorizontalAlignment.Center;
            btn.ImageOffset = new Point(10, 0);
            btn.TextOffset = new Point(10, 0);



        }
        private void SetUpAllButtons()
        {
            SetupButton(btnSaveUpdateClients);
            SetupButton(btnCloseSaveClientForm);

        }
        private void SetUpUpdateClientPanel()
        {
           
            UpdateClientPanel.BorderRadius = 1;
            UpdateClientPanel.FillColor = Color.DarkGray;
            UpdateClientPanel.BorderColor = Color.FromArgb(220, 220, 220);
            UpdateClientPanel.BorderThickness = 1;


            UpdateClientPanel.ShadowDecoration.Enabled = true;
            UpdateClientPanel.ShadowDecoration.Color = Color.Gray;
            UpdateClientPanel.ShadowDecoration.Depth = 10;
            UpdateClientPanel.ShadowDecoration.Shadow = new Padding(5);
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
        private void UpdateClientPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCloseSaveClientForm_Click(object sender, EventArgs e)
        {
           
            this.Close();
           
        }

        private bool UpdateClient()
        {
            clsClients UpdateClient = clsClients.Find(IDClientSent);

            if (UpdateClient != null)
            {
                ErrorProvider errorProvider1 = new ErrorProvider();

                errorProvider1.Clear();
                bool isValid = true;


                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    errorProvider1.SetError(txtFirstName, "Required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    errorProvider1.SetError(txtLastName, "Required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtGender.Text))
                {
                    errorProvider1.SetError(txtGender, "Required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    errorProvider1.SetError(txtPhoneNumber, "Required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPinCode.Text))
                {
                    errorProvider1.SetError(txtPinCode, "Required");
                    isValid = false;
                }

                if (!decimal.TryParse(txtAccountBalance.Text, out decimal balance))
                {
                    errorProvider1.SetError(txtAccountBalance, "Enter a valid number");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                UpdateClient.FirstName = txtFirstName.Text;
                UpdateClient.LastName = txtLastName.Text;
                UpdateClient.Gender = txtGender.Text;
                UpdateClient.Email = txtEmail.Text;
                UpdateClient.PhoneNumber = txtPhoneNumber.Text;
                UpdateClient.PinCode = txtPinCode.Text;
                UpdateClient.AccountBalance = balance;




                return UpdateClient.Save();


            }
            else
            {
                return false;
            }



        }
        private void btnUpdateClients_Click(object sender, EventArgs e)
        {
            

            if (UpdateClient())
            {
                MessageBox.Show("Client Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

        }

        private void ClientIDLable_Click(object sender, EventArgs e)
        {

        }
    }
}
