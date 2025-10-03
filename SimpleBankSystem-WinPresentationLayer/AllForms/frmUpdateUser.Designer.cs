namespace SimpleBankSystem_WinPresentationLayer
{
    partial class frmUpdateUser
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
            this.UpdateUserPanel = new Guna.UI2.WinForms.Guna2Panel();
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
            this.lbPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbFirstname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveUpdateUseer = new Guna.UI2.WinForms.Guna2Button();
            this.UserIDLable = new System.Windows.Forms.Label();
            this.thisUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UpdateUserPanel.SuspendLayout();
            this.PermissionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateUserPanel
            // 
            this.UpdateUserPanel.Controls.Add(this.lbPhone);
            this.UpdateUserPanel.Controls.Add(this.txtPhoneNumber);
            this.UpdateUserPanel.Controls.Add(this.UserIDLable);
            this.UpdateUserPanel.Controls.Add(this.thisUserID);
            this.UpdateUserPanel.Controls.Add(this.PermissionGB);
            this.UpdateUserPanel.Controls.Add(this.lbPassword);
            this.UpdateUserPanel.Controls.Add(this.lbEmail);
            this.UpdateUserPanel.Controls.Add(this.lbGender);
            this.UpdateUserPanel.Controls.Add(this.lbLastName);
            this.UpdateUserPanel.Controls.Add(this.lbFirstname);
            this.UpdateUserPanel.Controls.Add(this.txtPassword);
            this.UpdateUserPanel.Controls.Add(this.txtGender);
            this.UpdateUserPanel.Controls.Add(this.txtEmail);
            this.UpdateUserPanel.Controls.Add(this.txtLastName);
            this.UpdateUserPanel.Controls.Add(this.txtFirstName);
            this.UpdateUserPanel.Controls.Add(this.btnClose);
            this.UpdateUserPanel.Controls.Add(this.btnSaveUpdateUseer);
            this.UpdateUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateUserPanel.Location = new System.Drawing.Point(0, 0);
            this.UpdateUserPanel.Name = "UpdateUserPanel";
            this.UpdateUserPanel.Size = new System.Drawing.Size(654, 764);
            this.UpdateUserPanel.TabIndex = 33;
            this.UpdateUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateClientPanel_Paint);
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
            this.PermissionGB.Location = new System.Drawing.Point(115, 492);
            this.PermissionGB.Name = "PermissionGB";
            this.PermissionGB.Size = new System.Drawing.Size(426, 162);
            this.PermissionGB.TabIndex = 47;
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
            // 
            // lbPassword
            // 
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPassword.Location = new System.Drawing.Point(55, 434);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 27);
            this.lbPassword.TabIndex = 46;
            this.lbPassword.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbEmail.Location = new System.Drawing.Point(56, 291);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 27);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Email :";
            // 
            // lbGender
            // 
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGender.Location = new System.Drawing.Point(56, 218);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(89, 27);
            this.lbGender.TabIndex = 43;
            this.lbGender.Text = "Geneder :";
            // 
            // lbLastName
            // 
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbLastName.Location = new System.Drawing.Point(52, 142);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(102, 27);
            this.lbLastName.TabIndex = 42;
            this.lbLastName.Text = "Last name :";
            // 
            // lbFirstname
            // 
            this.lbFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbFirstname.Location = new System.Drawing.Point(49, 68);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(105, 27);
            this.lbFirstname.TabIndex = 41;
            this.lbFirstname.Text = "First name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(220, 423);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(371, 51);
            this.txtPassword.TabIndex = 39;
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
            this.txtGender.Location = new System.Drawing.Point(220, 207);
            this.txtGender.Name = "txtGender";
            this.txtGender.PlaceholderText = "";
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(371, 51);
            this.txtGender.TabIndex = 37;
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
            this.txtEmail.Location = new System.Drawing.Point(220, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(371, 51);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
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
            this.txtLastName.Location = new System.Drawing.Point(220, 135);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(371, 51);
            this.txtLastName.TabIndex = 35;
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
            this.txtFirstName.Location = new System.Drawing.Point(220, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(371, 51);
            this.txtFirstName.TabIndex = 34;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(346, 667);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 74);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveUpdateUseer
            // 
            this.btnSaveUpdateUseer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUpdateUseer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUpdateUseer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveUpdateUseer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveUpdateUseer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveUpdateUseer.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdateUseer.Location = new System.Drawing.Point(115, 667);
            this.btnSaveUpdateUseer.Name = "btnSaveUpdateUseer";
            this.btnSaveUpdateUseer.Size = new System.Drawing.Size(195, 74);
            this.btnSaveUpdateUseer.TabIndex = 32;
            this.btnSaveUpdateUseer.Text = "Update";
            this.btnSaveUpdateUseer.Click += new System.EventHandler(this.btnSaveUpdateUseer_Click);
            // 
            // UserIDLable
            // 
            this.UserIDLable.AutoSize = true;
            this.UserIDLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.UserIDLable.Location = new System.Drawing.Point(163, 21);
            this.UserIDLable.Name = "UserIDLable";
            this.UserIDLable.Size = new System.Drawing.Size(28, 25);
            this.UserIDLable.TabIndex = 52;
            this.UserIDLable.Text = "??";
            this.UserIDLable.Click += new System.EventHandler(this.ClientIDLable_Click);
            // 
            // thisUserID
            // 
            this.thisUserID.BackColor = System.Drawing.Color.Transparent;
            this.thisUserID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisUserID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.thisUserID.Location = new System.Drawing.Point(52, 21);
            this.thisUserID.Name = "thisUserID";
            this.thisUserID.Size = new System.Drawing.Size(78, 27);
            this.thisUserID.TabIndex = 51;
            this.thisUserID.Text = "User ID :";
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(220, 351);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(371, 51);
            this.txtPhoneNumber.TabIndex = 53;
            // 
            // lbPhone
            // 
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPhone.Location = new System.Drawing.Point(58, 366);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(70, 27);
            this.lbPhone.TabIndex = 54;
            this.lbPhone.Text = "Phone :";
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 764);
            this.Controls.Add(this.UpdateUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateUser";
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            this.UpdateUserPanel.ResumeLayout(false);
            this.UpdateUserPanel.PerformLayout();
            this.PermissionGB.ResumeLayout(false);
            this.PermissionGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UpdateUserPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFirstname;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSaveUpdateUseer;
        private Guna.UI2.WinForms.Guna2GroupBox PermissionGB;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowLogInRegister;
        private Guna.UI2.WinForms.Guna2CheckBox chkManagingUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkTranactions;
        private Guna.UI2.WinForms.Guna2CheckBox chkFindClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkpUpdateClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddNewClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkListClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkAllPermission;
        private System.Windows.Forms.Label UserIDLable;
        private Guna.UI2.WinForms.Guna2HtmlLabel thisUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
    }
}