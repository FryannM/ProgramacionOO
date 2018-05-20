using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new vistas.frmLogin());
=======
            Application.Run(new frmMenu());
>>>>>>> e37a5f28813bb57f099c7b8f47aa9772f87fd8d8
        }
    }
}
