using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankBusinesLayer;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
           
        private void SetupPanelStyle()
        {
            MainPanel.BorderRadius = 1;
            MainPanel.FillColor = Color.DarkGray;
            MainPanel.BorderColor = Color.FromArgb(220, 220, 220);
            MainPanel.BorderThickness = 1;


            MainPanel.ShadowDecoration.Enabled = true;
            MainPanel.ShadowDecoration.Color = Color.Gray;
            MainPanel.ShadowDecoration.Depth = 10;
            MainPanel.ShadowDecoration.Shadow = new Padding(5);

            Pic2.Image = Properties.Resources.bank;
        }
       
        private void SetupLeftPanelStyle()
        {

            LeftSidePanel.Dock = DockStyle.Left; // ← أهم شيء
            LeftSidePanel.Width = 220;           // ← عرض السايدبار
            LeftSidePanel.BorderRadius = 0;

            LeftSidePanel.FillColor = Color.DarkGray; // أو أي لون تحبه
            LeftSidePanel.BorderColor = Color.FromArgb(220, 220, 220);
            LeftSidePanel.BorderThickness = 1;

            // تفعيل الظل
            LeftSidePanel.ShadowDecoration.Enabled = true;
            LeftSidePanel.ShadowDecoration.Color = Color.AliceBlue;
            LeftSidePanel.ShadowDecoration.Depth = 10;
            LeftSidePanel.ShadowDecoration.Shadow = new Padding(3, 0, 5, 0);
        }

      

        private void Center()
        {
            MainPanel.Dock = DockStyle.Fill;


            Guna.UI2.WinForms.Guna2Panel innerPanel = new Guna.UI2.WinForms.Guna2Panel();
            innerPanel.BackColor = Color.Transparent;
            innerPanel.Size = new Size(this.Width / 2, this.Height / 2);
            innerPanel.Anchor = AnchorStyles.None;
            MainPanel.Controls.Add(innerPanel);

        }

        private void SetupButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.Width = LeftSidePanel.Width - 40;  // أو ببساطة: 200
            btn.Height = 50;
            btn.Margin = new Padding(10, 10, 10, 0); // (يسار، أعلى، يمين، أسفل)
            btn.BorderRadius = 10;
            btn.Font = new Font("Segoe UI", 11);
            btn.FillColor = Color.DodgerBlue;
            btn.ForeColor = Color.White;
            btn.HoverState.FillColor = Color.FromArgb(0, 90, 200);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = HorizontalAlignment.Left;
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageOffset = new Point(10, 0);
            btn.TextOffset = new Point(10, 0);


            btnClients.Image = Properties.Resources.contacts_24W;
            btnUsers.Image = Properties.Resources.Users;
            btnTransactions.Image = Properties.Resources.us_dollar_24;
            btnTransfer.Image = Properties.Resources.banknotes_24;
            btnLoginRegister.Image = Properties.Resources.key_24;
            btnLogout.Image = Properties.Resources.lock_24;
        }

        private void SetUpAllButtons()
        {
            SetupButton(btnClients);
            SetupButton(btnUsers);
            SetupButton(btnTransactions);
            SetupButton(btnTransfer);
            SetupButton(btnLoginRegister);
            SetupButton(btnLogout);

        }

        private void Pic1()
        {
            Pic2.Image = Properties.Resources.bankBig;

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut()
        {
            clsUsers User = new clsUsers();

            User.UserID = clsGlobal.CurrentUser.UserID;

            if (User != null)
            {

                User.SaveRegister(User.UserID, 2);
                
            }
          
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            SettingUp();
        }

        private void SettingUp()
        {
            Center();
            SetupPanelStyle();
            SetupLeftPanelStyle();

            SetUpAllButtons();
            CurrentUserText();
            Pic1();
            CurrentUserLb.Text = clsGlobal.CurrentUser.Username.ToUpper();
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOut();
            this.Close();
        }

        private void CurrentUserText()
        {
            //CurrentUserLb.Text = clsGlobal.CurrentUser.Username.ToString();

        }

        private void CurrentUserLb_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddusClient(usClients usClient)
        {
            usClient.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(usClient);


        }
        private void btnClients_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pListClients))
            {
                MessageBox.Show("🚫 You do not have permission to show list clients.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {


                usClients usClient = new usClients();
                typeof(Panel).InvokeMember("DoubleBuffered",
                 System.Reflection.BindingFlags.SetProperty |
                 System.Reflection.BindingFlags.Instance |
                 System.Reflection.BindingFlags.NonPublic,
                 null, usClient, new object[] { true });


                AddusClient(usClient);
            }
        }

        private void AddUsers(usUsers usUsers)
        {
            usUsers.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(usUsers);


        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pManagingUsers))
            {
                MessageBox.Show("🚫 You do not have permission to Managing Users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {


                usUsers usUsers = new usUsers();
                typeof(Panel).InvokeMember("DoubleBuffered",
                 System.Reflection.BindingFlags.SetProperty |
                 System.Reflection.BindingFlags.Instance |
                 System.Reflection.BindingFlags.NonPublic,
                 null, usUsers, new object[] { true });

                AddUsers(usUsers);
            }

        }

       
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Now.ToString("d");
            CurrentTime.Text = DateTime.Now.ToString("t");

            DatePic.Image = Properties.Resources.date_to_24;
            TimePic.Image = Properties.Resources.time_8_24;
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pTranactions))
            {
                MessageBox.Show("🚫 You do not have permission to Transactions.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {


                usTransactions Trans = new usTransactions();

                typeof(Panel).InvokeMember("DoubleBuffered",
                 System.Reflection.BindingFlags.SetProperty |
                 System.Reflection.BindingFlags.Instance |
                 System.Reflection.BindingFlags.NonPublic,
                 null, Trans, new object[] { true });

                AddTransactions(Trans);
            }
        }

        private void AddTransactions(usTransactions Trans)
        {
            Trans.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Trans);


        }
        private void AddLogRegoster(usLogRegister Log)
        {
            Log.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Log);


        }
        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pShowLogInRegister))
            {
                MessageBox.Show("🚫 You do not have permission to show login register.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usLogRegister Log = new usLogRegister();

                typeof(Panel).InvokeMember("DoubleBuffered",
                 System.Reflection.BindingFlags.SetProperty |
                 System.Reflection.BindingFlags.Instance |
                 System.Reflection.BindingFlags.NonPublic,
                 null, Log, new object[] { true });

                AddLogRegoster(Log);

            }

        }

        private void AddTransferRegoster(usTransferrRegister TRLog)
        {
            TRLog.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(TRLog);


        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pTranactions))
            {
                MessageBox.Show("🚫 You do not have permission to show transfer register.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usTransferrRegister TRLog = new usTransferrRegister();

                typeof(Panel).InvokeMember("DoubleBuffered",
                 System.Reflection.BindingFlags.SetProperty |
                 System.Reflection.BindingFlags.Instance |
                 System.Reflection.BindingFlags.NonPublic,
                 null, TRLog, new object[] { true });

                AddTransferRegoster(TRLog); 
            }
        }
    }
}
