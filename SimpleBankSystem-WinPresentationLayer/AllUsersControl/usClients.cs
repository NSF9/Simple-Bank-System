using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankBusinesLayer;
using SystemBankBusinessLayer;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class usClients : UserControl
    {
        public usClients()
        {
            InitializeComponent();
        }

        private void usClients_Load(object sender, EventArgs e)
        {


            SetUpAllButtons();
            LoadDataGridView();
            SetupDataGridViewStyle();
            LoadDataGridView();
            SetupSearchClientsTextBox();
        }


        private void SetupSearchClientsTextBox()
        {
            txtSearchClients.Focus();
            txtSearchClients.PlaceholderText = "Enter account number";
            txtSearchClients.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtSearchClients.BorderRadius = 10;
            txtSearchClients.FillColor = Color.WhiteSmoke;
            txtSearchClients.BorderColor = Color.Silver;
            txtSearchClients.BorderThickness = 1;
            txtSearchClients.Font = new Font("Segoe UI", 11);


            txtSearchClients.RightToLeft = RightToLeft.No;
        }

        //private void SetupButton(Guna.UI2.WinForms.Guna2Button btn)
        //{

        //    btn.Height = 50;
        //    btn.Margin = new Padding(10, 10, 10, 0); // (يسار، أعلى، يمين، أسفل)
        //    btn.BorderRadius = 10;
        //    btn.Font = new Font("Segoe UI", 11);
        //    btn.FillColor = Color.DodgerBlue;
        //    btn.ForeColor = Color.White;
        //    btn.HoverState.FillColor = Color.FromArgb(0, 90, 200);
        //    btn.Cursor = Cursors.Hand;
        //    btn.TextAlign = HorizontalAlignment.Left;
        //    btn.ImageAlign = HorizontalAlignment.Left;
        //    btn.ImageOffset = new Point(10, 0);
        //    btn.TextOffset = new Point(10, 0);



        //}

        private void SetUpAllButtons()
        {
            clsButtonStyler.ButtonADUStyler(btnAddNewClients);
            clsButtonStyler.ButtonADUStyler(btnUpdateClients);
            clsButtonStyler.ButtonADUStyler(btnDeleteClients);

        }
        private void LoadDataGridView()
        {

            DgShowAllClients.DataSource = clsClients.ShowAllClients();


        }
        private int _SelectedClientID = -1;

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (DgShowAllClients.SelectedRows.Count > 0 && DgShowAllClients.SelectedRows[0].Visible)
            {
                _SelectedClientID = Convert.ToInt32(DgShowAllClients.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                _SelectedClientID = -1; // أو أي قيمة تدل على "لا يوجد تحديد"
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void ClientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewClients_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewClients_Click_1(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pAddNewClient))
            {
                MessageBox.Show("🚫 You do not have permission to add a new client.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            else
            {

                frmAddNewClients frmAddClients = new frmAddNewClients();
                frmAddClients.ShowDialog();
            }
            LoadDataGridView();
        }

        private void btnUpdateClients_Click(object sender, EventArgs e)
        {

            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pUpdateClient))
            {
                MessageBox.Show("🚫 You do not have permission to Update client.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dgvClients_SelectionChanged(sender, e);

                if (_SelectedClientID == -1)
                {

                    MessageBox.Show("Please Select a Client from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                clsClients Client = clsClients.Find(_SelectedClientID);

                if (Client != null)
                {
                    frmUpdateClients frmUpdateClients = new frmUpdateClients(Client);

                    frmUpdateClients.ShowDialog();

                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("this Client does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private bool DeleteClient()
        {



            clsClients Client = new clsClients();



            if (_SelectedClientID != -1 && Client != null)
            {
                return Client.DeleteClient(_SelectedClientID);
            }
            else
            {
                return false;
            }

        }
        private void btnDeleteClients_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pDeleteClient))
            {
                MessageBox.Show("🚫 You do not have permission to Delete client.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            dgvClients_SelectionChanged(sender, e);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Delete Confirmation",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                if (DeleteClient())
                {
                    MessageBox.Show("Client deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("This client does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchClients.Text.Trim().ToLower();

            DgShowAllClients.CurrentCell = null; // نلغي التحديد لتفادي الخطأ

            foreach (DataGridViewRow row in DgShowAllClients.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells[1].Value?.ToString().ToLower() ?? "";

                bool match = cellValue.Contains(searchText);
                row.Visible = match;
            }
        }
    }
}
