namespace SimpleBankSystem_WinPresentationLayer
{
    partial class frmClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LeftSidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TimePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DatePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeleteClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewClients = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Userlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CurrentUserLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgShowAllClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ClientPaneltimer = new System.Windows.Forms.Timer(this.components);
            this.ClientsPanel.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsPanel
            // 
            this.ClientsPanel.Controls.Add(this.LeftSidePanel);
            this.ClientsPanel.Controls.Add(this.DgShowAllClients);
            this.ClientsPanel.Controls.Add(this.Pic2);
            this.ClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientsPanel.Name = "ClientsPanel";
            this.ClientsPanel.Size = new System.Drawing.Size(2000, 1148);
            this.ClientsPanel.TabIndex = 0;
            this.ClientsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ClientsPanel_Paint);
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Controls.Add(this.guna2HtmlLabel2);
            this.LeftSidePanel.Controls.Add(this.guna2HtmlLabel1);
            this.LeftSidePanel.Controls.Add(this.TimePic);
            this.LeftSidePanel.Controls.Add(this.DatePic);
            this.LeftSidePanel.Controls.Add(this.btnDeleteClients);
            this.LeftSidePanel.Controls.Add(this.btnUpdateClients);
            this.LeftSidePanel.Controls.Add(this.btnAddNewClients);
            this.LeftSidePanel.Controls.Add(this.guna2PictureBox1);
            this.LeftSidePanel.Controls.Add(this.Userlb);
            this.LeftSidePanel.Controls.Add(this.CurrentUserLb);
            this.LeftSidePanel.ForeColor = System.Drawing.Color.Coral;
            this.LeftSidePanel.Location = new System.Drawing.Point(3, 3);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(291, 1185);
            this.LeftSidePanel.TabIndex = 11;
            this.LeftSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftSidePanel_Paint);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(51, 266);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(94, 32);
            this.guna2HtmlLabel2.TabIndex = 16;
            this.guna2HtmlLabel2.Text = "DateHere";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(51, 304);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 32);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "TimeHere";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
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
            // 
            // btnDeleteClients
            // 
            this.btnDeleteClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClients.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClients.Location = new System.Drawing.Point(10, 586);
            this.btnDeleteClients.Name = "btnDeleteClients";
            this.btnDeleteClients.Size = new System.Drawing.Size(195, 74);
            this.btnDeleteClients.TabIndex = 9;
            this.btnDeleteClients.Text = "Delete";
            this.btnDeleteClients.Click += new System.EventHandler(this.btnDeleteClients_Click);
            // 
            // btnUpdateClients
            // 
            this.btnUpdateClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateClients.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClients.Location = new System.Drawing.Point(10, 486);
            this.btnUpdateClients.Name = "btnUpdateClients";
            this.btnUpdateClients.Size = new System.Drawing.Size(195, 74);
            this.btnUpdateClients.TabIndex = 7;
            this.btnUpdateClients.Text = "Update";
            // 
            // btnAddNewClients
            // 
            this.btnAddNewClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClients.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClients.Location = new System.Drawing.Point(10, 381);
            this.btnAddNewClients.Name = "btnAddNewClients";
            this.btnAddNewClients.Size = new System.Drawing.Size(195, 74);
            this.btnAddNewClients.TabIndex = 6;
            this.btnAddNewClients.Text = "Add New";
            this.btnAddNewClients.Click += new System.EventHandler(this.btnAddNewClients_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SimpleBankSystem_WinPresentationLayer.Properties.Resources.bankBig;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(16, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(197, 160);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
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
            // 
            // DgShowAllClients
            // 
            this.DgShowAllClients.AllowUserToAddRows = false;
            this.DgShowAllClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgShowAllClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgShowAllClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgShowAllClients.ColumnHeadersHeight = 4;
            this.DgShowAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgShowAllClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgShowAllClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllClients.Location = new System.Drawing.Point(352, 296);
            this.DgShowAllClients.Name = "DgShowAllClients";
            this.DgShowAllClients.ReadOnly = true;
            this.DgShowAllClients.RowHeadersVisible = false;
            this.DgShowAllClients.Size = new System.Drawing.Size(1384, 824);
            this.DgShowAllClients.TabIndex = 10;
            this.DgShowAllClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgShowAllClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgShowAllClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgShowAllClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgShowAllClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgShowAllClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgShowAllClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgShowAllClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgShowAllClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgShowAllClients.ThemeStyle.HeaderStyle.Height = 4;
            this.DgShowAllClients.ThemeStyle.ReadOnly = true;
            this.DgShowAllClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgShowAllClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgShowAllClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgShowAllClients.ThemeStyle.RowsStyle.Height = 22;
            this.DgShowAllClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Pic2
            // 
            this.Pic2.ImageRotate = 0F;
            this.Pic2.Location = new System.Drawing.Point(672, 460);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(802, 564);
            this.Pic2.TabIndex = 0;
            this.Pic2.TabStop = false;
            // 
            // ClientPaneltimer
            // 
            this.ClientPaneltimer.Interval = 1000;
            this.ClientPaneltimer.Tick += new System.EventHandler(this.ClientPaneltimer_Tick);
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1148);
            this.Controls.Add(this.ClientsPanel);
            this.Name = "frmClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.ClientsPanel.ResumeLayout(false);
            this.LeftSidePanel.ResumeLayout(false);
            this.LeftSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientsPanel;
        private Guna.UI2.WinForms.Guna2PictureBox Pic2;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClients;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClients;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClients;
        private Guna.UI2.WinForms.Guna2DataGridView DgShowAllClients;
        private Guna.UI2.WinForms.Guna2Panel LeftSidePanel;
        private Guna.UI2.WinForms.Guna2PictureBox TimePic;
        private Guna.UI2.WinForms.Guna2PictureBox DatePic;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Userlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel CurrentUserLb;
        private System.Windows.Forms.Timer ClientPaneltimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}