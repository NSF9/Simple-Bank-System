using Guna.UI2.WinForms;
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
    public partial class usUsers : UserControl
    {
        public usUsers()
        {
            InitializeComponent();
        }

        private void usUsers_Load(object sender, EventArgs e)
        {
            SetUpButtons();
            ShowAllUsers();
            SetUpDGV();
            SetupSearchUsersTextBox();
        }

        private void SetupSearchUsersTextBox()
        {
            txtSearchUsers.Focus();
            txtSearchUsers.PlaceholderText = "Enter username";
            txtSearchUsers.Size = new Size(370, 45); // نفس ارتفاع الباسورد

            txtSearchUsers.BorderRadius = 10;
            txtSearchUsers.FillColor = Color.WhiteSmoke;
            txtSearchUsers.BorderColor = Color.Silver;
            txtSearchUsers.BorderThickness = 1;
            txtSearchUsers.Font = new Font("Segoe UI", 11);


            txtSearchUsers.RightToLeft = RightToLeft.No;
        }

        private int _SelectedUserID = 0;

        private void SetUpButtons()
        {
            clsButtonStyler.ButtonADUStyler(btnAddNewUser);
            clsButtonStyler.ButtonADUStyler(btnUpdateUser);
            clsButtonStyler.ButtonADUStyler(btnDeleteUser);
        }

        private void ShowAllUsers()
        {
            DgShowAllUsers.DataSource = clsUsers.ShowAllUsers();
        }
        private void SetUpDGV()
        {
            
            clsDataGridviewStyler.SetUpDGV(DgShowAllUsers);
        }
        private void DgShowAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgShowAllUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (DgShowAllUsers.SelectedRows.Count > 0 && DgShowAllUsers.SelectedRows[0].Visible)
            {
                _SelectedUserID = Convert.ToInt32(DgShowAllUsers.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                _SelectedUserID = -1; // أو أي قيمة تدل على "لا يوجد تحديد"
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmad = new frmAddNewUser();
            frmad.ShowDialog();

            ShowAllUsers();
        }


        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchUsers.Text.Trim().ToLower();

            DgShowAllUsers.CurrentCell = null; // نلغي التحديد لتفادي الخطأ

            foreach (DataGridViewRow row in DgShowAllUsers.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells[5].Value?.ToString().ToLower() ?? "";

                bool match = cellValue.Contains(searchText);
                row.Visible = match;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {



            if (_SelectedUserID == -1)
            {

                MessageBox.Show("Please Select a User from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            clsUsers User = clsUsers.Find(_SelectedUserID);

            if (User != null)
            {
                frmUpdateUser frmUpdateUser = new frmUpdateUser(User,_SelectedUserID);

                frmUpdateUser.ShowDialog();
                ShowAllUsers();

            }
            else
            {
                MessageBox.Show("this User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
        private bool DeleteUsers()
        {

            if (_SelectedUserID != -1)
            {
                return clsUsers.DeleteUser(_SelectedUserID);
            }
            else
            {
                return false;
            }

        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(clsUsers.enPermission.pDeleteClient))
            {
                MessageBox.Show("🚫 You do not have permission to Delete User.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DgShowAllUsers_SelectionChanged(sender, e);


            if (_SelectedUserID == clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("You cannot Delete Current User",
                   "Access Denied",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            if (_SelectedUserID == 1)
            {
                MessageBox.Show("You cannot Delete Admin User",
                   "Access Denied",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this User?", "Delete Confirmation",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                if (DeleteUsers())
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllUsers();
                }
                else
                {
                    MessageBox.Show("This User does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
