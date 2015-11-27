/**
 *  Student Names: Thomas Herr, Nathan Siu
 *  Date: 11/27/2015
 *  Purpose: Facilitate input and storage of employee information to text file and parse that file to display results
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RADAssignmentTwo
{
    public partial class OutputForm : Form
    {
        private StreamReader fileReader;

        public OutputForm(string fileName)
        {
            InitializeComponent();

            try
            {
                fileReader = new StreamReader(fileName);
            }
            catch(ArgumentNullException nullException)
            {
                MessageBox.Show("No file to read", nullException.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch(IOException ioExecption)
            {
                MessageBox.Show("File Input Error", ioExecption.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //Grab a value from the fileReader to display initially
            string line = fileReader.ReadLine();
            string[] values = line.Split(',');

            if (fileReader.Peek()!=-1)
            {
                nextButton.Enabled = false;
            }

        }
    }
}
