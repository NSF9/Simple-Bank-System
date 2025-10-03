using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBankSystem_WinPresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frmlogion = new frmLogin();
            if (frmlogion.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}
