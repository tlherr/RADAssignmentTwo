using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADAssignmentTwo
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

            //open a save file dialog
            //Get the filename specified by the user
            //Read/Write to that file

            Application.Run(new InputForm("changethis.txt"));
            //Application.Run(new OutputForm("changethis.txt"));

        }
    }
}
