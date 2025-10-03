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
using SystemBankBusinessLayer;

namespace SimpleBankSystem_WinPresentationLayer
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void SetupPanelStyle()
        {
            ClientsPanel.BorderRadius = 1;
            ClientsPanel.FillColor = Color.DarkGray;
            ClientsPanel.BorderColor = Color.FromArgb(220, 220, 220);
            ClientsPanel.BorderThickness = 1;


            ClientsPanel.ShadowDecoration.Enabled = true;
            ClientsPanel.ShadowDecoration.Color = Color.Gray;
            ClientsPanel.ShadowDecoration.Depth = 10;
            ClientsPanel.ShadowDecoration.Shadow = new Padding(5);

            Pic2.Image = Properties.Resources.bank;
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            SetupPanelStyle();
            SetUpAllButtons();
            ShowAllClients();
            SetupDataGridViewStyle();
            SetupLeftPanelStyle();
        }

        private void SetupButton(Guna.UI2.WinForms.Guna2Button btn)
        {
           
            btn.Height = 50;
            btn.Margin = new Padding(10, 10, 10, 0); // (يسار، أعلى، يمين، أسفل)
            btn.BorderRadius = 10;
            btn.Font = new Font("Segoe UI", 11);
            btn.FillColor = Color.DodgerBlue;
            btn.ForeColor = Color.White;
            btn.HoverState.FillColor = Color.FromArgb(0, 90, 200);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = HorizontalAlignment.Left;
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageOffset = new Point(10, 0);
            btn.TextOffset = new Point(10, 0);


        
        }

        private void SetUpAllButtons()
        {
            SetupButton(btnAddNewClients);
            SetupButton(btnUpdateClients);
            SetupButton(btnDeleteClients);
          

        }
        private void ShowAllClients()
        {

            DgShowAllClients.DataSource = clsClients.ShowAllClients();
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
            frmAddNewClients frmAddClients = new frmAddNewClients();
            frmAddClients.ShowDialog();
        }

        private void SetupLeftPanelStyle()
        {

            LeftSidePanel.Dock = DockStyle.Left; // ← أهم شيء
            LeftSidePanel.Width = 220;           // ← عرض السايدبار
            LeftSidePanel.BorderRadius = 0;

            LeftSidePanel.FillColor = Color.DarkGray; // أو أي لون تحبه
            LeftSidePanel.BorderColor = Color.FromArgb(220, 220, 220);
            LeftSidePanel.BorderThickness = 1;

            // تفعيل الظل
            LeftSidePanel.ShadowDecoration.Enabled = true;
            LeftSidePanel.ShadowDecoration.Color = Color.AliceBlue;
            LeftSidePanel.ShadowDecoration.Depth = 10;
            LeftSidePanel.ShadowDecoration.Shadow = new Padding(3, 0, 5, 0);
        }

        private void LeftSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CurrentDate_Click(object sender, EventArgs e)
        {

        }

        private void ClientPaneltimer_Tick(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = DateTime.Now.ToString("d");
            guna2HtmlLabel2.Text = DateTime.Now.ToString("t");

            DatePic.Image = Properties.Resources.date_to_24;
            TimePic.Image = Properties.Resources.time_8_24;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteClients_Click(object sender, EventArgs e)
        {

        }
    }
}
