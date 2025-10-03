using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SimpleBankSystem_WinPresentationLayer
{
    public static class clsButtonStyler
    {
        public static void ButtonADUStyler(Guna2Button btn)
        {
            btn.Height = 50;
            btn.Margin = new Padding(10, 10, 10, 0);
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
    }

    internal class ButtonAUDStyler
    {
    }
}
