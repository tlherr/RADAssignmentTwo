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
        //Define instance level variables
        const float HOURLY_WAGE = 10.50F;
        private StreamReader fileReader;

        public OutputForm()
        {
            //When Output form is constructed create new StreamReader and ensure file is valid
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

            //If the length of the file is zero there is no content, if this is true just notify the user and exit
            long fLength = new System.IO.FileInfo(Program.fileName).Length;

            if(fLength==0)
            {
                MessageBox.Show(this, "Input File is Empty", "Please enter data and reopen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileReader.Close();
                Application.Exit();
            }
            else
            {
                //There is content in the file, attempt to display it so we can preload the first record on form load
                getNextLine();
            }
        }

        //Method to display file info
        //will attempt a readline
        //Always check if the next line exists so we can disalbe the next button and notify the user
        //That we have reached  the end of the file
        void getNextLine()
        {
            try
            {
                string line = fileReader.ReadLine();

                string[] values = line.Split(',');

                displayLine(values[0], values[1], values[2]);

                if (fileReader.EndOfStream)
                {
                    nextButton.Enabled = false;
                    MessageBox.Show(this, "No more employee records to display", "All Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(IOException ioExecption)
            {
                MessageBox.Show(this, ioExecption.Message, "Please check data file for errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Display the actual file data to the user via the interface
        //Also calulcate and display the hours worked as a currency formatted float
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
        //Next button clicked, display next line in file
        private void nextButton_Click(object sender, EventArgs e)
        {
            getNextLine();
        }
        //Form closing event handler, make sure to close fileReader resource to free memory and unlock the file IO
        void OutputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileReader.Close();
        }
        //Release resources and exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Release any resources before exiting
            fileReader.Close();
            this.Close();
            Application.Exit();
        }
    }
}
