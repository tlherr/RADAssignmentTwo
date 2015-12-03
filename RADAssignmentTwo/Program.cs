using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RADAssignmentTwo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static public String fileName { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;

                Application.Run(new InputForm());
                Application.Run(new OutputForm());
            }
        }


        static void OnProcessExit(object sender, EventArgs e)
        {
            //Make sure everything is closed
        }
    }
}
