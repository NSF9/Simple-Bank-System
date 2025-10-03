using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankBusinesLayer;
using SystemBankBusinessLayer;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class usTransferrRegister : UserControl
    {
        public usTransferrRegister()
        {
            InitializeComponent();
        }
     
        private void ShowAllTransferredReg()
        {

            DgShowAllLogTranssferred.DataSource = clsClients.ShowAllTransferLog();


        }
        private void SetupSearchTransferTextBox()
        {
            txtSearchTransferred.Focus();
            txtSearchTransferred.PlaceholderText = "Enter account number";
            txtSearchTransferred.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtSearchTransferred.BorderRadius = 10;
            txtSearchTransferred.FillColor = Color.WhiteSmoke;
            txtSearchTransferred.BorderColor = Color.Silver;
            txtSearchTransferred.BorderThickness = 1;
            txtSearchTransferred.Font = new Font("Segoe UI", 11);


            txtSearchTransferred.RightToLeft = RightToLeft.No;
        }
        private void DgShowAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupDataGridViewStyle()
        {
            var dgv = DgShowAllLogTranssferred;

            // الحواف
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // صفوف متناوبة بلون ناعم



            // العنوان
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;

            // لون الأعمدة
            dgv.ColumnHeadersHeight = 50;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.ForeColor = Color.DimGray;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 250); // تحديد ناعم
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // الخط
            dgv.GridColor = Color.LightGray;

            // الحواف
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;

            // الحواف الدائرية (خفيفة)
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(220, 230, 250);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;

            // الحواف الخارجية
            dgv.BackgroundColor = Color.White;




        }
       
           
        
        private void usTransferrRegister_Load(object sender, EventArgs e)
        {
            ShowAllTransferredReg();
            SetupDataGridViewStyle();
            SetupSearchTransferTextBox();
            txtSearchTransferred_TextChanged(sender, e);
        }

        private void txtSearchTransferred_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchTransferred.Text.Trim().ToLower();

            DgShowAllLogTranssferred.CurrentCell = null; // نلغي التحديد لتفادي الخطأ

            foreach (DataGridViewRow row in DgShowAllLogTranssferred.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells[2].Value?.ToString().ToLower() ?? "";

                bool match = cellValue.Contains(searchText);
                row.Visible = match;
            }
        }
    }
}
