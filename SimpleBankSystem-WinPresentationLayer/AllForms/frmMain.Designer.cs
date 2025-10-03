namespace SimpleBankSystem_WinPresentationLayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LeftSidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TimePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DatePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CurrentTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CurrentDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Userlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CurrentUserLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoginRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MainPanel.Controls.Add(this.guna2PictureBox1);
            this.MainPanel.Location = new System.Drawing.Point(237, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1774, 1184);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SimpleBankSystem_WinPresentationLayer.Properties.Resources.bankBig;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(759, 356);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(644, 538);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.LeftSidePanel.Controls.Add(this.btnTransfer);
            this.LeftSidePanel.Controls.Add(this.TimePic);
            this.LeftSidePanel.Controls.Add(this.DatePic);
            this.LeftSidePanel.Controls.Add(this.CurrentTime);
            this.LeftSidePanel.Controls.Add(this.CurrentDate);
            this.LeftSidePanel.Controls.Add(this.Pic2);
            this.LeftSidePanel.Controls.Add(this.Userlb);
            this.LeftSidePanel.Controls.Add(this.CurrentUserLb);
            this.LeftSidePanel.Controls.Add(this.btnUsers);
            this.LeftSidePanel.Controls.Add(this.btnTransactions);
            this.LeftSidePanel.Controls.Add(this.btnClients);
            this.LeftSidePanel.Controls.Add(this.btnLoginRegister);
            this.LeftSidePanel.Controls.Add(this.btnLogout);
            this.LeftSidePanel.ForeColor = System.Drawing.Color.Coral;
            this.LeftSidePanel.Location = new System.Drawing.Point(3, 0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(233, 1187);
            this.LeftSidePanel.TabIndex = 0;
            this.LeftSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftSidePanel_Paint);
            // 
            // TimePic
            // 
            this.TimePic.Image = global::SimpleBankSystem_WinPresentationLayer.Properties.Resources.time_8_24;
            this.TimePic.ImageRotate = 0F;
            this.TimePic.Location = new System.Drawing.Point(10, 312);
            this.TimePic.Name = "TimePic";
            this.TimePic.Size = new System.Drawing.Size(24, 24);
            this.TimePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TimePic.TabIndex = 14;
            this.TimePic.TabStop = false;
            // 
            // DatePic
            // 
            this.DatePic.BackColor = System.Drawing.Color.Transparent;
            this.DatePic.FillColor = System.Drawing.Color.Transparent;
            this.DatePic.Image = global::SimpleBankSystem_WinPresentationLayer.Properties.Resources.date_to_24;
            this.DatePic.ImageRotate = 0F;
            this.DatePic.Location = new System.Drawing.Point(10, 262);
            this.DatePic.Name = "DatePic";
            this.DatePic.Size = new System.Drawing.Size(24, 24);
            this.DatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DatePic.TabIndex = 13;
            this.DatePic.TabStop = false;
            this.DatePic.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
            // 
            // CurrentTime
            // 
            this.CurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CurrentTime.Location = new System.Drawing.Point(48, 307);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(97, 32);
            this.CurrentTime.TabIndex = 13;
            this.CurrentTime.Text = "TimeHere";
            // 
            // CurrentDate
            // 
            this.CurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CurrentDate.Location = new System.Drawing.Point(51, 258);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(94, 32);
            this.CurrentDate.TabIndex = 12;
            this.CurrentDate.Text = "DateHere";
            this.CurrentDate.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // Pic2
            // 
            this.Pic2.Image = global::SimpleBankSystem_WinPresentationLayer.Properties.Resources.bankBig;
            this.Pic2.ImageRotate = 0F;
            this.Pic2.Location = new System.Drawing.Point(16, 10);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(150, 150);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic2.TabIndex = 0;
            this.Pic2.TabStop = false;
            this.Pic2.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Userlb
            // 
            this.Userlb.BackColor = System.Drawing.Color.Transparent;
            this.Userlb.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Userlb.Location = new System.Drawing.Point(10, 204);
            this.Userlb.Name = "Userlb";
            this.Userlb.Size = new System.Drawing.Size(101, 52);
            this.Userlb.TabIndex = 11;
            this.Userlb.Text = "User :";
            // 
            // CurrentUserLb
            // 
            this.CurrentUserLb.BackColor = System.Drawing.Color.Transparent;
            this.CurrentUserLb.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserLb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CurrentUserLb.Location = new System.Drawing.Point(117, 204);
            this.CurrentUserLb.Name = "CurrentUserLb";
            this.CurrentUserLb.Size = new System.Drawing.Size(96, 52);
            this.CurrentUserLb.TabIndex = 10;
            this.CurrentUserLb.Text = "Unull";
            this.CurrentUserLb.Click += new System.EventHandler(this.CurrentUserLb_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(10, 459);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(195, 74);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(10, 550);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(195, 74);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnClients
            // 
            this.btnClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(10, 368);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(195, 74);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginRegister.ForeColor = System.Drawing.Color.White;
            this.btnLoginRegister.Location = new System.Drawing.Point(9, 732);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(195, 74);
            this.btnLoginRegister.TabIndex = 3;
            this.btnLoginRegister.Text = "Login Register";
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(8, 823);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 74);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(10, 641);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(195, 74);
            this.btnTransfer.TabIndex = 15;
            this.btnTransfer.Text = "Transfer Register";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1187);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.LeftSidePanel.ResumeLayout(false);
            this.LeftSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel LeftSidePanel;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private Guna.UI2.WinForms.Guna2Button btnLoginRegister;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel CurrentUserLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel Userlb;
        private Guna.UI2.WinForms.Guna2PictureBox Pic2;
        private Guna.UI2.WinForms.Guna2HtmlLabel CurrentDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel CurrentTime;
        private Guna.UI2.WinForms.Guna2PictureBox TimePic;
        private Guna.UI2.WinForms.Guna2PictureBox DatePic;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
    }
}