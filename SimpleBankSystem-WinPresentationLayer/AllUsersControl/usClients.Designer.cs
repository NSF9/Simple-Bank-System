namespace SimpleBankSystem_WinPresentationLayer
{
    partial class usClients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewClients = new Guna.UI2.WinForms.Guna2Button();
            this.DgShowAllClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearchClients = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteClients
            // 
            this.btnDeleteClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClients.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClients.Location = new System.Drawing.Point(1539, 214);
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
            this.btnUpdateClients.Location = new System.Drawing.Point(1298, 214);
            this.btnUpdateClients.Name = "btnUpdateClients";
            this.btnUpdateClients.Size = new System.Drawing.Size(195, 74);
            this.btnUpdateClients.TabIndex = 7;
            this.btnUpdateClients.Text = "Update";
            this.btnUpdateClients.Click += new System.EventHandler(this.btnUpdateClients_Click);
            // 
            // btnAddNewClients
            // 
            this.btnAddNewClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClients.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClients.Location = new System.Drawing.Point(1057, 215);
            this.btnAddNewClients.Name = "btnAddNewClients";
            this.btnAddNewClients.Size = new System.Drawing.Size(195, 74);
            this.btnAddNewClients.TabIndex = 6;
            this.btnAddNewClients.Text = "Add New";
            this.btnAddNewClients.Click += new System.EventHandler(this.btnAddNewClients_Click_1);
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
            this.DgShowAllClients.Location = new System.Drawing.Point(350, 294);
            this.DgShowAllClients.Name = "DgShowAllClients";
            this.DgShowAllClients.ReadOnly = true;
            this.DgShowAllClients.RowHeadersVisible = false;
            this.DgShowAllClients.Size = new System.Drawing.Size(1384, 824);
            this.DgShowAllClients.TabIndex = 13;
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
            this.Pic2.Location = new System.Drawing.Point(670, 458);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(802, 564);
            this.Pic2.TabIndex = 12;
            this.Pic2.TabStop = false;
            // 
            // txtSearchClients
            // 
            this.txtSearchClients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClients.DefaultText = "";
            this.txtSearchClients.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClients.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchClients.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClients.Location = new System.Drawing.Point(350, 214);
            this.txtSearchClients.Name = "txtSearchClients";
            this.txtSearchClients.PlaceholderText = "";
            this.txtSearchClients.SelectedText = "";
            this.txtSearchClients.Size = new System.Drawing.Size(701, 75);
            this.txtSearchClients.TabIndex = 14;
            this.txtSearchClients.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchClients);
            this.Controls.Add(this.DgShowAllClients);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.btnAddNewClients);
            this.Controls.Add(this.btnDeleteClients);
            this.Controls.Add(this.btnUpdateClients);
            this.Name = "usClients";
            this.Size = new System.Drawing.Size(2016, 1187);
            this.Load += new System.EventHandler(this.usClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDeleteClients;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClients;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClients;
        private Guna.UI2.WinForms.Guna2DataGridView DgShowAllClients;
        private Guna.UI2.WinForms.Guna2PictureBox Pic2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClients;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}
