namespace SimpleBankSystem_WinPresentationLayer
{
    partial class frmAddNewUser
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
            this.AddNewUserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PermissionGB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkShowLogInRegister = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkManagingUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTranactions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkFindClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkpUpdateClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkDeleteClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAddNewClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkListClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAllPermission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddNewUserPanel.SuspendLayout();
            this.PermissionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewUserPanel
            // 
            this.AddNewUserPanel.Controls.Add(this.txtPhoneNumber);
            this.AddNewUserPanel.Controls.Add(this.PermissionGB);
            this.AddNewUserPanel.Controls.Add(this.txtPinCode);
            this.AddNewUserPanel.Controls.Add(this.txtGender);
            this.AddNewUserPanel.Controls.Add(this.txtEmail);
            this.AddNewUserPanel.Controls.Add(this.txtLastName);
            this.AddNewUserPanel.Controls.Add(this.txtFirstName);
            this.AddNewUserPanel.Controls.Add(this.btnClose);
            this.AddNewUserPanel.Controls.Add(this.btnSaveNewUser);
            this.AddNewUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewUserPanel.Location = new System.Drawing.Point(0, 0);
            this.AddNewUserPanel.Name = "AddNewUserPanel";
            this.AddNewUserPanel.Size = new System.Drawing.Size(654, 764);
            this.AddNewUserPanel.TabIndex = 24;
            this.AddNewUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddNewUserPanel_Paint);
            // 
            // PermissionGB
            // 
            this.PermissionGB.Controls.Add(this.chkShowLogInRegister);
            this.PermissionGB.Controls.Add(this.chkManagingUsers);
            this.PermissionGB.Controls.Add(this.chkTranactions);
            this.PermissionGB.Controls.Add(this.chkFindClient);
            this.PermissionGB.Controls.Add(this.chkpUpdateClient);
            this.PermissionGB.Controls.Add(this.chkDeleteClient);
            this.PermissionGB.Controls.Add(this.chkAddNewClient);
            this.PermissionGB.Controls.Add(this.chkListClients);
            this.PermissionGB.Controls.Add(this.chkAllPermission);
            this.PermissionGB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PermissionGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PermissionGB.Location = new System.Drawing.Point(114, 465);
            this.PermissionGB.Name = "PermissionGB";
            this.PermissionGB.Size = new System.Drawing.Size(426, 162);
            this.PermissionGB.TabIndex = 31;
            this.PermissionGB.Text = "Permissions";
            this.PermissionGB.Click += new System.EventHandler(this.PermissionGB_Click);
            // 
            // chkShowLogInRegister
            // 
            this.chkShowLogInRegister.AutoSize = true;
            this.chkShowLogInRegister.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowLogInRegister.CheckedState.BorderRadius = 0;
            this.chkShowLogInRegister.CheckedState.BorderThickness = 0;
            this.chkShowLogInRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowLogInRegister.Location = new System.Drawing.Point(265, 125);
            this.chkShowLogInRegister.Name = "chkShowLogInRegister";
            this.chkShowLogInRegister.Size = new System.Drawing.Size(133, 19);
            this.chkShowLogInRegister.TabIndex = 8;
            this.chkShowLogInRegister.Text = "Show LogIn Register";
            this.chkShowLogInRegister.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowLogInRegister.UncheckedState.BorderRadius = 0;
            this.chkShowLogInRegister.UncheckedState.BorderThickness = 0;
            this.chkShowLogInRegister.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkManagingUsers
            // 
            this.chkManagingUsers.AutoSize = true;
            this.chkManagingUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkManagingUsers.CheckedState.BorderRadius = 0;
            this.chkManagingUsers.CheckedState.BorderThickness = 0;
            this.chkManagingUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkManagingUsers.Location = new System.Drawing.Point(265, 88);
            this.chkManagingUsers.Name = "chkManagingUsers";
            this.chkManagingUsers.Size = new System.Drawing.Size(111, 19);
            this.chkManagingUsers.TabIndex = 7;
            this.chkManagingUsers.Text = "Managing Users";
            this.chkManagingUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManagingUsers.UncheckedState.BorderRadius = 0;
            this.chkManagingUsers.UncheckedState.BorderThickness = 0;
            this.chkManagingUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkTranactions
            // 
            this.chkTranactions.AutoSize = true;
            this.chkTranactions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTranactions.CheckedState.BorderRadius = 0;
            this.chkTranactions.CheckedState.BorderThickness = 0;
            this.chkTranactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTranactions.Location = new System.Drawing.Point(265, 53);
            this.chkTranactions.Name = "chkTranactions";
            this.chkTranactions.Size = new System.Drawing.Size(86, 19);
            this.chkTranactions.TabIndex = 6;
            this.chkTranactions.Text = "Tranactions";
            this.chkTranactions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTranactions.UncheckedState.BorderRadius = 0;
            this.chkTranactions.UncheckedState.BorderThickness = 0;
            this.chkTranactions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkFindClient
            // 
            this.chkFindClient.AutoSize = true;
            this.chkFindClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFindClient.CheckedState.BorderRadius = 0;
            this.chkFindClient.CheckedState.BorderThickness = 0;
            this.chkFindClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFindClient.Location = new System.Drawing.Point(144, 125);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.Size = new System.Drawing.Size(83, 19);
            this.chkFindClient.TabIndex = 5;
            this.chkFindClient.Text = "Find Client";
            this.chkFindClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFindClient.UncheckedState.BorderRadius = 0;
            this.chkFindClient.UncheckedState.BorderThickness = 0;
            this.chkFindClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkpUpdateClient
            // 
            this.chkpUpdateClient.AutoSize = true;
            this.chkpUpdateClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkpUpdateClient.CheckedState.BorderRadius = 0;
            this.chkpUpdateClient.CheckedState.BorderThickness = 0;
            this.chkpUpdateClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkpUpdateClient.Location = new System.Drawing.Point(144, 88);
            this.chkpUpdateClient.Name = "chkpUpdateClient";
            this.chkpUpdateClient.Size = new System.Drawing.Size(98, 19);
            this.chkpUpdateClient.TabIndex = 4;
            this.chkpUpdateClient.Text = "Update Client";
            this.chkpUpdateClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkpUpdateClient.UncheckedState.BorderRadius = 0;
            this.chkpUpdateClient.UncheckedState.BorderThickness = 0;
            this.chkpUpdateClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.AutoSize = true;
            this.chkDeleteClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDeleteClient.CheckedState.BorderRadius = 0;
            this.chkDeleteClient.CheckedState.BorderThickness = 0;
            this.chkDeleteClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDeleteClient.Location = new System.Drawing.Point(144, 53);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.Size = new System.Drawing.Size(93, 19);
            this.chkDeleteClient.TabIndex = 3;
            this.chkDeleteClient.Text = "Delete Client";
            this.chkDeleteClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteClient.UncheckedState.BorderRadius = 0;
            this.chkDeleteClient.UncheckedState.BorderThickness = 0;
            this.chkDeleteClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkAddNewClient
            // 
            this.chkAddNewClient.AutoSize = true;
            this.chkAddNewClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAddNewClient.CheckedState.BorderRadius = 0;
            this.chkAddNewClient.CheckedState.BorderThickness = 0;
            this.chkAddNewClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAddNewClient.Location = new System.Drawing.Point(7, 125);
            this.chkAddNewClient.Name = "chkAddNewClient";
            this.chkAddNewClient.Size = new System.Drawing.Size(109, 19);
            this.chkAddNewClient.TabIndex = 2;
            this.chkAddNewClient.Text = "Add New Client";
            this.chkAddNewClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddNewClient.UncheckedState.BorderRadius = 0;
            this.chkAddNewClient.UncheckedState.BorderThickness = 0;
            this.chkAddNewClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkListClients
            // 
            this.chkListClients.AutoSize = true;
            this.chkListClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkListClients.CheckedState.BorderRadius = 0;
            this.chkListClients.CheckedState.BorderThickness = 0;
            this.chkListClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkListClients.Location = new System.Drawing.Point(7, 88);
            this.chkListClients.Name = "chkListClients";
            this.chkListClients.Size = new System.Drawing.Size(83, 19);
            this.chkListClients.TabIndex = 1;
            this.chkListClients.Text = "List Clients";
            this.chkListClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkListClients.UncheckedState.BorderRadius = 0;
            this.chkListClients.UncheckedState.BorderThickness = 0;
            this.chkListClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkAllPermission
            // 
            this.chkAllPermission.AutoSize = true;
            this.chkAllPermission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllPermission.CheckedState.BorderRadius = 0;
            this.chkAllPermission.CheckedState.BorderThickness = 0;
            this.chkAllPermission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllPermission.Location = new System.Drawing.Point(7, 53);
            this.chkAllPermission.Name = "chkAllPermission";
            this.chkAllPermission.Size = new System.Drawing.Size(106, 19);
            this.chkAllPermission.TabIndex = 0;
            this.chkAllPermission.Text = "All Permissions";
            this.chkAllPermission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAllPermission.UncheckedState.BorderRadius = 0;
            this.chkAllPermission.UncheckedState.BorderThickness = 0;
            this.chkAllPermission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAllPermission.CheckedChanged += new System.EventHandler(this.chkAllPermission_CheckedChanged);
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
            this.txtPinCode.Location = new System.Drawing.Point(141, 408);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PlaceholderText = "";
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(371, 51);
            this.txtPinCode.TabIndex = 30;
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
            this.txtGender.Location = new System.Drawing.Point(141, 171);
            this.txtGender.Name = "txtGender";
            this.txtGender.PlaceholderText = "";
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(371, 51);
            this.txtGender.TabIndex = 29;
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
            this.txtEmail.Location = new System.Drawing.Point(141, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(371, 51);
            this.txtEmail.TabIndex = 28;
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
            this.txtLastName.Location = new System.Drawing.Point(141, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(371, 51);
            this.txtLastName.TabIndex = 27;
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
            this.txtFirstName.Location = new System.Drawing.Point(141, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(371, 51);
            this.txtFirstName.TabIndex = 26;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(345, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 74);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveNewUser
            // 
            this.btnSaveNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveNewUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveNewUser.Location = new System.Drawing.Point(114, 649);
            this.btnSaveNewUser.Name = "btnSaveNewUser";
            this.btnSaveNewUser.Size = new System.Drawing.Size(195, 74);
            this.btnSaveNewUser.TabIndex = 24;
            this.btnSaveNewUser.Text = "Save";
            this.btnSaveNewUser.Click += new System.EventHandler(this.btnSaveNewUser_Click);
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(141, 329);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(371, 51);
            this.txtPhoneNumber.TabIndex = 32;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 764);
            this.Controls.Add(this.AddNewUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.AddNewUserPanel.ResumeLayout(false);
            this.PermissionGB.ResumeLayout(false);
            this.PermissionGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel AddNewUserPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtPinCode;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSaveNewUser;
        private Guna.UI2.WinForms.Guna2GroupBox PermissionGB;
        private Guna.UI2.WinForms.Guna2CheckBox chkFindClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkpUpdateClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddNewClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkListClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkAllPermission;
        private Guna.UI2.WinForms.Guna2CheckBox chkTranactions;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowLogInRegister;
        private Guna.UI2.WinForms.Guna2CheckBox chkManagingUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
    }
}