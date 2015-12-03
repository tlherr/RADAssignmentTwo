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
        public StreamWriter fileWriter;
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
            if (nameTextBox.Text != String.Empty && numberTextBox.Text != String.Empty && hoursTextBox.Text != String.Empty)
            {
                try
                {
                    float hours = float.Parse(hoursTextBox.Text);

                    //Use named constants for these limits
                    if (hours < MIN_NUM_HOURS || hours > MAX_NUM_HOURS)
                    {
                        MessageBox.Show(this,"Invalid Entry", "Hours must be between 0 and 40", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string StringToWrite = nameTextBox.Text + "," + numberTextBox.Text + "," + hours.ToString() + "\n";

                        try {
                            //File.AppendAllText(Program.fileName, StringToWrite);
                            fileWriter.Write(StringToWrite);
                            

                            nameTextBox.Clear();
                            numberTextBox.Clear();
                            hoursTextBox.Clear();
                        }  
                        catch(ArgumentNullException argumentNullException)
                        {
                            MessageBox.Show(this, "No File to write to", argumentNullException.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //catch other exceptions
                    }
         
                }
                catch(FormatException formatException)
                {
                    MessageBox.Show(this, formatException.Message, "Please enter a number for the hours", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                   
                    
            }
            else
            {
                MessageBox.Show("Please Fill Out all the required fields");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            //Make sure file resource is closed
            fileWriter.Close();
            OutputForm form = new OutputForm();

            form.Show();
            this.Close();
        }

   
    }
}
