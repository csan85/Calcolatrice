using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
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

            //Application.Run(new Implementazione1.Calcolatrice());
            //Application.Run(new Implementazione2.FormCalcolatrice());
            Application.Run(new Implementazione3.FormCalcolatrice());
        }
    }
}
