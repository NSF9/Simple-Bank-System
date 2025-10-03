using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms;


namespace SimpleBankSystem_WinPresentationLayer
{

    public static class clsDataGridviewStyler
    {
        public static void SetUpDGV(Guna2DataGridView DVG)
        {
            var dgv = DVG;

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
    }
    internal class clsDgvStyler
    {
    }
}
