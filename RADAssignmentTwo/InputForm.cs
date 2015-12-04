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
    public partial class InputForm : Form
    {
        //Instance level variables
        const float MAX_NUM_HOURS = 40;
        const float MIN_NUM_HOURS = 0;
        private StreamWriter fileWriter;

        //Initialize StreamWriter in the constructor. True param allows us to append data vs overwrite
        public InputForm()
        {
            InitializeComponent();
            fileWriter = new StreamWriter(Program.fileName,true);
        }

        //Clear user inputs when requested
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
            hoursTextBox.Clear();
        }

        //Save user entered data
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Check to make sure user entered a name
            if (nameTextBox.Text != String.Empty)
            {
                //Check to make sure user entered and employee number
                if (numberTextBox.Text != String.Empty)
                {
                    //Check to make sure user entered hours worked
                    if(hoursTextBox.Text != String.Empty)
                    {
                        try
                        {
                            //Remember hours is a float (allows partial values), attempt to parse and catch any exceptions
                            float hours = float.Parse(hoursTextBox.Text);

                            //Make sure the parsed value is within expected range
                            if (hours < MIN_NUM_HOURS || hours > MAX_NUM_HOURS)
                            {
                                MessageBox.Show(this, "Invalid Entry", "Hours must be between 0 and 40", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                hoursTextBox.Focus();
                                hoursTextBox.SelectAll();
                            }
                            else
                            {
                                string StringToWrite = nameTextBox.Text + "," + numberTextBox.Text + "," + hours.ToString();

                                //If all data is valid try to write it to file, catch and IO exceptions
                                try
                                {
                                    fileWriter.WriteLine(StringToWrite);

                                    nameTextBox.Clear();
                                    numberTextBox.Clear();
                                    hoursTextBox.Clear();
                                }
                                catch (IOException IOException)
                                {
                                    MessageBox.Show(this, "Failed to write to specified file", IOException.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (FormatException formatException)
                        {
                            MessageBox.Show(this, formatException.Message, "Please enter a valid number for the hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            hoursTextBox.Focus();
                            hoursTextBox.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hours is a required field");
                        hoursTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Employee Number is a required field");
                    numberTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Name is a required field");
                nameTextBox.Focus();
            }
        }

        //Form closing event handler
        void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileWriter.Close();
        }

        //Exit button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            fileWriter.Close();
            Application.Exit();
        }

        //Done button event handler
        private void doneButton_Click(object sender, EventArgs e)
        {
            //Make sure file resource is closed
            fileWriter.Close();
            this.Hide();
            OutputForm form = new OutputForm();

            form.Show();
        }
    }
}
