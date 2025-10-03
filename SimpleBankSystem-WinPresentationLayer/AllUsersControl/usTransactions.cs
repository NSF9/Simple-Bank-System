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
    public partial class usTransactions : UserControl
    {
        private int _SelectedIDClient;
        public usTransactions()
        {
            InitializeComponent();
        }

        private void usTransactions_Load(object sender, EventArgs e)
        {
            ShowAllClients();
            SetupDataGridViewStyle();
            SetupSearchTransferTextBox();
            SetUpAllButtons();
            DgShowAllClients_SelectionChanged(sender,e);
            txtSearchTransfer_TextChanged(sender, e);
        }
        private void SetUpAllButtons()
        {
            clsButtonStyler.ButtonADUStyler(btnDeposit);
            clsButtonStyler.ButtonADUStyler(btnWithdrawal);
            clsButtonStyler.ButtonADUStyler(btnTransfer);

        }
        private void DgShowAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SetupSearchTransferTextBox()
        {
            txtSearchTransfer.Focus();
            txtSearchTransfer.PlaceholderText = "Enter account number";
            txtSearchTransfer.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtSearchTransfer.BorderRadius = 10;
            txtSearchTransfer.FillColor = Color.WhiteSmoke;
            txtSearchTransfer.BorderColor = Color.Silver;
            txtSearchTransfer.BorderThickness = 1;
            txtSearchTransfer.Font = new Font("Segoe UI", 11);


            txtSearchTransfer.RightToLeft = RightToLeft.No;
        }

        private void DgShowAllClients_SelectionChanged(object sender, EventArgs e)
        {

            if (DgShowAllClients.SelectedRows.Count > 0 && DgShowAllClients.SelectedRows[0].Visible)
            {
                _SelectedIDClient = Convert.ToInt32(DgShowAllClients.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                _SelectedIDClient = -1; // أو أي قيمة تدل على "لا يوجد تحديد"
            }
             
        }
        private void SetupDataGridViewStyle()
        {
            var dgv = DgShowAllClients;

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

        private void ShowAllClients()
        {
            DgShowAllClients.DataSource = clsClients.ShowAllClients();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            if (_SelectedIDClient == -1)
            {

                MessageBox.Show("Please Select a Client from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DgShowAllClients_SelectionChanged(sender, e);

            clsClients DepositClient = clsClients.Find(_SelectedIDClient);

            if (DepositClient != null)
            {
                frmDeposit frmDeposit = new frmDeposit(DepositClient, _SelectedIDClient);
                frmDeposit.ShowDialog();

                ShowAllClients();
            }
            else
            {
                MessageBox.Show("Please select Client");
            }

        }

        private void txtSearchTransfer_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchTransfer.Text.Trim().ToLower();

            DgShowAllClients.CurrentCell = null; // نلغي التحديد لتفادي الخطأ

            foreach (DataGridViewRow row in DgShowAllClients.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells[1].Value?.ToString().ToLower() ?? "";

                bool match = cellValue.Contains(searchText);
                row.Visible = match;
            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (_SelectedIDClient == -1)
            {

                MessageBox.Show("Please Select a Client from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DgShowAllClients_SelectionChanged(sender, e);

            clsClients WithdrawalClient = clsClients.Find(_SelectedIDClient);

            if (WithdrawalClient != null)
            {
                frmWithdrawal frmWithdrawal = new frmWithdrawal(WithdrawalClient, _SelectedIDClient);
                frmWithdrawal.ShowDialog();

                ShowAllClients();
            }
            else
            {
                MessageBox.Show("Please select Client");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            frmTransfer frmTransfer = new frmTransfer();
            frmTransfer.ShowDialog();
            ShowAllClients();

        }
    }
}
