namespace SimpleBankSystem_WinPresentationLayer
{
    partial class frmDeposit
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
            this.DepositPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientIDLable = new System.Windows.Forms.Label();
            this.thisClientID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPinCode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbFirstname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDepsite = new Guna.UI2.WinForms.Guna2Button();
            this.DepositPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepositPanel
            // 
            this.DepositPanel.Controls.Add(this.txtAmount);
            this.DepositPanel.Controls.Add(this.lbAmount);
            this.DepositPanel.Controls.Add(this.ClientIDLable);
            this.DepositPanel.Controls.Add(this.thisClientID);
            this.DepositPanel.Controls.Add(this.guna2HtmlLabel6);
            this.DepositPanel.Controls.Add(this.lbPinCode);
            this.DepositPanel.Controls.Add(this.lbPhoneNumber);
            this.DepositPanel.Controls.Add(this.lbEmail);
            this.DepositPanel.Controls.Add(this.lbGender);
            this.DepositPanel.Controls.Add(this.lbLastName);
            this.DepositPanel.Controls.Add(this.lbFirstname);
            this.DepositPanel.Controls.Add(this.txtAccountBalance);
            this.DepositPanel.Controls.Add(this.txtPinCode);
            this.DepositPanel.Controls.Add(this.txtPhoneNumber);
            this.DepositPanel.Controls.Add(this.txtGender);
            this.DepositPanel.Controls.Add(this.txtEmail);
            this.DepositPanel.Controls.Add(this.txtLastName);
            this.DepositPanel.Controls.Add(this.txtFirstName);
            this.DepositPanel.Controls.Add(this.btnClose);
            this.DepositPanel.Controls.Add(this.btnDepsite);
            this.DepositPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepositPanel.Location = new System.Drawing.Point(0, 0);
            this.DepositPanel.Name = "DepositPanel";
            this.DepositPanel.Size = new System.Drawing.Size(638, 1000);
            this.DepositPanel.TabIndex = 28;
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(251, 648);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(173, 30);
            this.txtAmount.TabIndex = 68;
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbAmount.Location = new System.Drawing.Point(149, 651);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(86, 27);
            this.lbAmount.TabIndex = 67;
            this.lbAmount.Text = "Amount :";
            // 
            // ClientIDLable
            // 
            this.ClientIDLable.AutoSize = true;
            this.ClientIDLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIDLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ClientIDLable.Location = new System.Drawing.Point(159, 21);
            this.ClientIDLable.Name = "ClientIDLable";
            this.ClientIDLable.Size = new System.Drawing.Size(28, 25);
            this.ClientIDLable.TabIndex = 66;
            this.ClientIDLable.Text = "??";
            // 
            // thisClientID
            // 
            this.thisClientID.BackColor = System.Drawing.Color.Transparent;
            this.thisClientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisClientID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.thisClientID.Location = new System.Drawing.Point(48, 21);
            this.thisClientID.Name = "thisClientID";
            this.thisClientID.Size = new System.Drawing.Size(89, 27);
            this.thisClientID.TabIndex = 65;
            this.thisClientID.Text = "Client ID :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(48, 523);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(160, 27);
            this.guna2HtmlLabel6.TabIndex = 64;
            this.guna2HtmlLabel6.Text = "Account Balance :";
            // 
            // lbPinCode
            // 
            this.lbPinCode.BackColor = System.Drawing.Color.Transparent;
            this.lbPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinCode.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPinCode.Location = new System.Drawing.Point(47, 446);
            this.lbPinCode.Name = "lbPinCode";
            this.lbPinCode.Size = new System.Drawing.Size(90, 27);
            this.lbPinCode.TabIndex = 63;
            this.lbPinCode.Text = "Pin code :";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPhoneNumber.Location = new System.Drawing.Point(48, 369);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(146, 27);
            this.lbPhoneNumber.TabIndex = 62;
            this.lbPhoneNumber.Text = "Phone number  :";
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbEmail.Location = new System.Drawing.Point(51, 292);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 27);
            this.lbEmail.TabIndex = 61;
            this.lbEmail.Text = "Email :";
            // 
            // lbGender
            // 
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGender.Location = new System.Drawing.Point(52, 215);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(89, 27);
            this.lbGender.TabIndex = 60;
            this.lbGender.Text = "Geneder :";
            // 
            // lbLastName
            // 
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbLastName.Location = new System.Drawing.Point(51, 138);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(102, 27);
            this.lbLastName.TabIndex = 59;
            this.lbLastName.Text = "Last name :";
            // 
            // lbFirstname
            // 
            this.lbFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbFirstname.Location = new System.Drawing.Point(48, 64);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(105, 27);
            this.lbFirstname.TabIndex = 58;
            this.lbFirstname.Text = "First name :";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountBalance.DefaultText = "";
            this.txtAccountBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountBalance.Location = new System.Drawing.Point(219, 523);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.PlaceholderText = "";
            this.txtAccountBalance.SelectedText = "";
            this.txtAccountBalance.Size = new System.Drawing.Size(320, 30);
            this.txtAccountBalance.TabIndex = 57;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.DefaultText = "";
            this.txtPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPinCode.Location = new System.Drawing.Point(219, 446);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PlaceholderText = "";
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(320, 30);
            this.txtPinCode.TabIndex = 56;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(219, 369);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(320, 30);
            this.txtPhoneNumber.TabIndex = 55;
            // 
            // txtGender
            // 
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.DefaultText = "";
            this.txtGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.Location = new System.Drawing.Point(219, 215);
            this.txtGender.Name = "txtGender";
            this.txtGender.PlaceholderText = "";
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(320, 30);
            this.txtGender.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(219, 292);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 53;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(219, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(320, 30);
            this.txtLastName.TabIndex = 52;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(219, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(320, 30);
            this.txtFirstName.TabIndex = 51;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(320, 899);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 74);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDepsite
            // 
            this.btnDepsite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDepsite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDepsite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDepsite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDepsite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDepsite.ForeColor = System.Drawing.Color.White;
            this.btnDepsite.Location = new System.Drawing.Point(89, 899);
            this.btnDepsite.Name = "btnDepsite";
            this.btnDepsite.Size = new System.Drawing.Size(195, 74);
            this.btnDepsite.TabIndex = 28;
            this.btnDepsite.Text = "Depsite";
            this.btnDepsite.Click += new System.EventHandler(this.btnDepsite_Click);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 1000);
            this.Controls.Add(this.DepositPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.DepositPanel.ResumeLayout(false);
            this.DepositPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel DepositPanel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnDepsite;
        private System.Windows.Forms.Label ClientIDLable;
        private Guna.UI2.WinForms.Guna2HtmlLabel thisClientID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPinCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFirstname;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountBalance;
        private Guna.UI2.WinForms.Guna2TextBox txtPinCode;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbAmount;
    }
}