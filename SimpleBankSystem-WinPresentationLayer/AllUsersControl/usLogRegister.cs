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

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class usLogRegister : UserControl
    {
        public usLogRegister()
        {
            InitializeComponent();
        }

        private void usLogRegister_Load(object sender, EventArgs e)
        {
            ShowLog();
            DGVLog(); 
            SetupLogTextBox();
            txtSearchLogAccount_TextChanged(sender,e);
        }

        private void ShowLog()
        {
            DgShowLog.DataSource = clsUsers.ShowAllLogRegister();
        }

       
        private void DGVLog()
        {
            clsDataGridviewStyler.SetUpDGV(DgShowLog); 

        }
        private void SetupLogTextBox()
        {


            txtSearchLogAccount.PlaceholderText = "Enter account number";
            txtSearchLogAccount.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtSearchLogAccount.BorderRadius = 10;
            txtSearchLogAccount.FillColor = Color.WhiteSmoke;
            txtSearchLogAccount.BorderColor = Color.Silver;
            txtSearchLogAccount.BorderThickness = 1;
            txtSearchLogAccount.Font = new Font("Segoe UI", 11);


            txtSearchLogAccount.RightToLeft = RightToLeft.No;
        }

        private void DgShowAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchLogAccount_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchLogAccount.Text.Trim().ToLower();

            DgShowLog.CurrentCell = null; // نلغي التحديد لتفادي الخطأ

            foreach (DataGridViewRow row in DgShowLog.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells[1].Value?.ToString().ToLower() ?? "";

                bool match = cellValue.Contains(searchText);
                row.Visible = match;
            }
        }
    }
}
