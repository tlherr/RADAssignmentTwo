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
        public StreamReader fileReader { get; private set; }

        const float HOURLY_WAGE = 10.50F;

        public OutputForm()
        {
            InitializeComponent();

            try
            {
                fileReader = new StreamReader(Program.fileName);
            }
            catch (ArgumentNullException nullException)
            {
                MessageBox.Show("No file to read", nullException.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (IOException ioExecption)
            {
                MessageBox.Show("File Input Error", ioExecption.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            //Grab a value from the fileReader to display initially
            string line = fileReader.ReadLine();
            string[] values = line.Split(',');

            displayLine(values[0], values[1], values[2]);
		
            if (fileReader.Peek() != -1)
            {
                nextButton.Enabled = false;
            }

        }


        void displayLine(string Name, string employeeNumber, string hoursWorked)
        {
            employeeNameTextBox.Text = Name;
            employeeNumberTextBox.Text = employeeNumber;
            hoursWorkedTextBox.Text = hoursWorked;

            try
            {
                float hoursWorkedFloat = float.Parse(hoursWorked);
                weeklyPayTextBox.Text = String.Format("{0:C}", hoursWorkedFloat*HOURLY_WAGE);
            } 
            catch (Exception ex) {
                MessageBox.Show("Unable to parse hours, please ensure a valid number");
            }

        }


    }
}
