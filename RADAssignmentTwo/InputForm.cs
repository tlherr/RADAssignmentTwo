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
        const float MAX_NUM_HOURS = 40;
        const float MIN_NUM_HOURS = 0;
        private StreamWriter fileWriter;

        public InputForm()
        {
            InitializeComponent();
            fileWriter = new StreamWriter(Program.fileName,true);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
            hoursTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty)
            {
                if (numberTextBox.Text != String.Empty)
                {
                    if(hoursTextBox.Text != String.Empty)
                    {
                        try
                        {
                            float hours = float.Parse(hoursTextBox.Text);

                            if (hours < MIN_NUM_HOURS || hours > MAX_NUM_HOURS)
                            {
                                MessageBox.Show(this, "Invalid Entry", "Hours must be between 0 and 40", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                hoursTextBox.Focus();
                                hoursTextBox.SelectAll();
                            }
                            else
                            {
                                string StringToWrite = nameTextBox.Text + "," + numberTextBox.Text + "," + hours.ToString();

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

        void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileWriter.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            fileWriter.Close();
            Application.Exit();
        }

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
