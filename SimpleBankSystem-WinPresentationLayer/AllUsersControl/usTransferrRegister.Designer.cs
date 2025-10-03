namespace SimpleBankSystem_WinPresentationLayer
{
    partial class usTransferrRegister
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
            this.txtSearchTransferred = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgShowAllLogTranssferred = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllLogTranssferred)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchTransferred
            // 
            this.txtSearchTransferred.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTransferred.DefaultText = "";
            this.txtSearchTransferred.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchTransferred.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchTransferred.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransferred.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTransferred.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTransferred.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchTransferred.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTransferred.Location = new System.Drawing.Point(350, 213);
            this.txtSearchTransferred.Name = "txtSearchTransferred";
            this.txtSearchTransferred.PlaceholderText = "";
            this.txtSearchTransferred.SelectedText = "";
            this.txtSearchTransferred.Size = new System.Drawing.Size(701, 75);
            this.txtSearchTransferred.TabIndex = 27;
            this.txtSearchTransferred.TextChanged += new System.EventHandler(this.txtSearchTransferred_TextChanged);
            // 
            // DgShowAllLogTranssferred
            // 
            this.DgShowAllLogTranssferred.AllowUserToAddRows = false;
            this.DgShowAllLogTranssferred.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgShowAllLogTranssferred.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgShowAllLogTranssferred.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgShowAllLogTranssferred.ColumnHeadersHeight = 4;
            this.DgShowAllLogTranssferred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgShowAllLogTranssferred.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgShowAllLogTranssferred.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllLogTranssferred.Location = new System.Drawing.Point(350, 294);
            this.DgShowAllLogTranssferred.Name = "DgShowAllLogTranssferred";
            this.DgShowAllLogTranssferred.ReadOnly = true;
            this.DgShowAllLogTranssferred.RowHeadersVisible = false;
            this.DgShowAllLogTranssferred.Size = new System.Drawing.Size(1384, 824);
            this.DgShowAllLogTranssferred.TabIndex = 26;
            this.DgShowAllLogTranssferred.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllLogTranssferred.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgShowAllLogTranssferred.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgShowAllLogTranssferred.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgShowAllLogTranssferred.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgShowAllLogTranssferred.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllLogTranssferred.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgShowAllLogTranssferred.ThemeStyle.HeaderStyle.Height = 4;
            this.DgShowAllLogTranssferred.ThemeStyle.ReadOnly = true;
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.Height = 22;
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgShowAllLogTranssferred.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgShowAllLogTranssferred.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgShowAllClients_CellContentClick);
            // 
            // usTransferrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchTransferred);
            this.Controls.Add(this.DgShowAllLogTranssferred);
            this.Name = "usTransferrRegister";
            this.Size = new System.Drawing.Size(2200, 1148);
            this.Load += new System.EventHandler(this.usTransferrRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgShowAllLogTranssferred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTransferred;
        private Guna.UI2.WinForms.Guna2DataGridView DgShowAllLogTranssferred;
    }
}
