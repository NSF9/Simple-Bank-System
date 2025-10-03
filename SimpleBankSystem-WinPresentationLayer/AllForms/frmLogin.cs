using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankBusinesLayer;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Sockets;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ShowMainMenu()

        {
            Main Main = new Main();
            Main.ShowDialog();

           
        }

        private void MakeButtonRound(object sender, EventArgs e)
        {
            guna2Button1.BorderRadius = 20;
            guna2Button1.FillColor = Color.RoyalBlue;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 12);
            guna2Button1.HoverState.FillColor = Color.MidnightBlue;
        }

        private void HandleLoginFailure()
        {
            FailedLoginCount++;

            if (FailedLoginCount > 3)
            {
                MessageBox.Show("Your account has been locked. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                guna2Button1.Enabled = false;
                return;
            }


            DialogResult Result = MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            if (Result == DialogResult.OK)
            {
                guna2TextBox2.Clear();
                guna2TextBoxPassword.Clear();
                guna2TextBox2.Focus();
            }

        }
        short FailedLoginCount = 0;
        private void FillUsernameAndPassword()
        {

            string Username = guna2TextBox2.Text;
            string Passowrd = guna2TextBoxPassword.Text;

            clsUsers User = clsUsers.Find(Username, Passowrd);

            if (User != null)
            {


                if (User.Username == Username && User.Passowrd == Passowrd)
                {

                    clsGlobal.CurrentUser = User;

                    User.SaveRegister(User.UserID, 1);

                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    FailedLoginCount = 0;

                }
                else
                {
                    HandleLoginFailure();
                }
            }

            else
            {
                MessageBox.Show("The username does not exist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TextBoxCheck()
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text) || string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                guna2TextBox2.Focus();
                return;

            }

            else if (string.IsNullOrEmpty(guna2TextBoxPassword.Text) || string.IsNullOrWhiteSpace(guna2TextBoxPassword.Text))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                guna2TextBoxPassword.Focus();
                return;
            }

            FillUsernameAndPassword();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {

            // TextBoxCheck();

        }

        
        private void Center()
        {
            LogInPanel.Dock = DockStyle.Fill;


            Guna.UI2.WinForms.Guna2Panel innerPanel = new Guna.UI2.WinForms.Guna2Panel();
            innerPanel.BackColor = Color.Transparent;
            innerPanel.Size = new Size(this.Width / 2, this.Height / 2);
            innerPanel.Anchor = AnchorStyles.None;
            LogInPanel.Controls.Add(innerPanel);

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Center();
            MakeButtonRound(sender, e);
            SetupPanelStyle();
            SetupLoginButton();
            SetupUsernameTextBox();
            SetupPasswordTextBox();
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TextBoxCheck();

        }

        private void SetupPanelStyle()
        {
            LogInPanel.BorderRadius = 1;
            LogInPanel.FillColor = Color.DarkGray;
            LogInPanel.BorderColor = Color.FromArgb(220, 220, 220);
            LogInPanel.BorderThickness = 1;


            LogInPanel.ShadowDecoration.Enabled = true;
            LogInPanel.ShadowDecoration.Color = Color.Gray;
            LogInPanel.ShadowDecoration.Depth = 10;
            LogInPanel.ShadowDecoration.Shadow = new Padding(5);
        }
        private void SetupLoginButton()
        {
            guna2Button1.Text = "Sign in";
            guna2Button1.Size = new Size(370, 45);
            guna2Button1.BorderRadius = 15;
            guna2Button1.FillColor = Color.DodgerBlue;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 12);
            guna2Button1.HoverState.FillColor = Color.FromArgb(0, 90, 200);
        }
        private void SetupUsernameTextBox()
        {
            guna2TextBox2.Focus();
            guna2TextBox2.PlaceholderText = "Username";
            guna2TextBox2.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            guna2TextBox2.BorderRadius = 10;
            guna2TextBox2.FillColor = Color.WhiteSmoke;
            guna2TextBox2.BorderColor = Color.Silver;
            guna2TextBox2.BorderThickness = 1;
            guna2TextBox2.Font = new Font("Segoe UI", 11);
            guna2TextBox2.IconLeft = Properties.Resources.user;
            guna2TextBox2.IconLeftSize = new Size(20, 20);
            guna2TextBox2.IconLeftOffset = new Point(5, 0);
            guna2TextBox2.RightToLeft = RightToLeft.No;
        }

        private void SetupPasswordTextBox()
        {
            guna2TextBoxPassword.Size = new Size(370, 45);
            guna2TextBoxPassword.PlaceholderText = "Password";
            guna2TextBoxPassword.PasswordChar = '●';
            guna2TextBoxPassword.BorderRadius = 10;
            guna2TextBoxPassword.FillColor = Color.WhiteSmoke;
            guna2TextBoxPassword.BorderColor = Color.Silver;
            guna2TextBoxPassword.BorderThickness = 1;
            guna2TextBoxPassword.Font = new Font("Segoe UI", 11);
            guna2TextBoxPassword.IconLeft = Properties.Resources.padlock;
            guna2TextBoxPassword.IconLeftSize = new Size(20, 20);
            guna2TextBoxPassword.IconLeftOffset = new Point(5, 0);
            guna2TextBoxPassword.RightToLeft = RightToLeft.No;
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.bank;
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {



        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                guna2TextBoxPassword.PasswordChar = '\0'; // يظهر النص
            }
            else
            {
                guna2TextBoxPassword.PasswordChar = '●';  // يخفي النص
            }

        }
    }
}

