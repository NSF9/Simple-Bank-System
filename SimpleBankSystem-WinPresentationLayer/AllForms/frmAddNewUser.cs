using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SystemBankBusinessLayer;
using SystemBankBusinesLayer;


namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

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
            SetupButton(btnSaveNewUser);
            SetupButton(btnClose);
            SetupPanelStyle();
        }

        
        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            SetUpAllButtons();
            txtBoxSetUp();
            SetUpGb();
           
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
        private void SetupPhoneTextBox()
        {
            txtPhoneNumber.PlaceholderText = "Email";
            txtPhoneNumber.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtPhoneNumber.BorderRadius = 10;
            txtPhoneNumber.FillColor = Color.WhiteSmoke;
            txtPhoneNumber.BorderColor = Color.Silver;
            txtPhoneNumber.BorderThickness = 1;
            txtPhoneNumber.Font = new Font("Segoe UI", 11);


            txtPhoneNumber.RightToLeft = RightToLeft.No;
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

        private void SetupPasswordTextBox()
        {


            txtPinCode.PlaceholderText = "Password";
            txtPinCode.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtPinCode.BorderRadius = 10;
            txtPinCode.FillColor = Color.WhiteSmoke;
            txtPinCode.BorderColor = Color.Silver;
            txtPinCode.BorderThickness = 1;
            txtPinCode.Font = new Font("Segoe UI", 11);


            txtPinCode.RightToLeft = RightToLeft.No;
        }
        private void SetupPanelStyle()
        {
            AddNewUserPanel.BorderRadius = 1;
            AddNewUserPanel.FillColor = Color.DarkGray;
            AddNewUserPanel.BorderColor = Color.FromArgb(220, 220, 220);
            AddNewUserPanel.BorderThickness = 1;


            AddNewUserPanel.ShadowDecoration.Enabled = true;
            AddNewUserPanel.ShadowDecoration.Color = Color.Gray;
            AddNewUserPanel.ShadowDecoration.Depth = 10;
            AddNewUserPanel.ShadowDecoration.Shadow = new Padding(5);


        }
        private void txtBoxSetUp()
        {
            SetupFirstNameTextBox();
            SetupLastNameTextBox();
            SetupGenderTextBox();
            SetupEmailTextBox();
            SetupPhoneTextBox();
            SetupPasswordTextBox();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUpGb()
        {
            PermissionGB.BorderRadius = 1;
            PermissionGB.BorderThickness = 2;
            PermissionGB.BorderColor = Color.DodgerBlue;

            PermissionGB.FillColor = Color.White;
            PermissionGB.ForeColor = Color.Black;
            PermissionGB.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            PermissionGB.CustomBorderColor = Color.DodgerBlue;
            PermissionGB.CustomBorderThickness = new Padding(1, 35, 1, 1); // يخلي العنوان واضح

            PermissionGB.TextAlign = HorizontalAlignment.Center;
            PermissionGB.ShadowDecoration.Enabled = true;
        }

        private void PermissionGB_Click(object sender, EventArgs e)
        {

        }
        private bool AddNewUser()
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

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                errorProvider1.SetError(txtPinCode, "Required");
                isValid = false;
            }


            if (!isValid)
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            clsUsers Users = new clsUsers();

            Users.FirstName = txtFirstName.Text;
            Users.LastName = txtLastName.Text;
            Users.Gender = txtGender.Text;
            Users.Email = txtEmail.Text;
            Users.PhoneNumber = txtPhoneNumber.Text;
            Users.Passowrd = txtPinCode.Text;
            Users.Permission = GivePermissions(Users);



            clsUsers LastUser = clsUsers.FindLastUser();

            if (LastUser != null && !string.IsNullOrWhiteSpace(LastUser.Username))
            {
                string lastUser = LastUser.Username;
                string firstLetter = lastUser.Substring(0, 1);
                string numericPart = lastUser.Substring(1);

                if (int.TryParse(numericPart, out int accNum))
                {
                    accNum++;
                    Users.Username = firstLetter + accNum.ToString();
                }
                else
                {
                    Users.Username = "U100"; // احتياطي
                }
            }


            return Users.Save();
        }

        private int GivePermissions(clsUsers User)
        {
            User.Permission = 0;

            if (chkAllPermission.Checked)
            {
                User.Permission += (int)enPermission.eAll;

                return User.Permission;
            }
           

            if (chkListClients.Checked)
            {
                User.Permission += (int)enPermission.pListClients;

            }

            if (chkAddNewClient.Checked)
            {
                User.Permission += (int)enPermission.pAddNewClient;

            }

            if (chkDeleteClient.Checked)
            {
                User.Permission += (int)enPermission.pDeleteClient;

            }

            if (chkpUpdateClient.Checked)
            {
                User.Permission += (int)enPermission.pUpdateClient;

            }

            if (chkFindClient.Checked)
            {
                User.Permission += (int)enPermission.pFindClient;

            }

            if (chkTranactions.Checked)
            {
                User.Permission += (int)enPermission.pTranactions;

            }

            if (chkManagingUsers.Checked)
            {
                User.Permission += (int)enPermission.pManagingUsers;

            }
            if (chkShowLogInRegister.Checked)
            {
                User.Permission += (int)enPermission.pShowLogInRegister;

            }


            return User.Permission;
        }
        
        private void AddNewUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveNewUser_Click(object sender, EventArgs e)
        {
            if (AddNewUser())

                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void chkAllPermission_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkAllPermission.Checked;

            
            chkFindClient.Enabled = !isChecked;
            chkAddNewClient.Enabled = !isChecked;
            chkDeleteClient.Enabled = !isChecked;
            chkpUpdateClient.Enabled = !isChecked;
            chkManagingUsers.Enabled = !isChecked;
            chkShowLogInRegister.Enabled = !isChecked;
            chkListClients.Enabled = !isChecked;
            chkTranactions.Enabled = !isChecked;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
