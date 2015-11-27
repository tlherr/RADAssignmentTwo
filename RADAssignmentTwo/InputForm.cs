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
        public InputForm(string fileName)
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
            hoursTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string FileName = "EmployeeInformation.txt";
            
            
            
                if (nameTextBox.Text != String.Empty && numberTextBox.Text != String.Empty && hoursTextBox.Text != String.Empty)
                {
                    try
                    {
                        int hours = Int32.Parse(hoursTextBox.Text);

                        if (hours > 40)
                        {
                            MessageBox.Show("Hours must be between 0 and 40");
                        }
                        else
                        {
                            string StringToWrite = nameTextBox.Text + "," + numberTextBox.Text + "," + hours.ToString() + "\n";

                            File.AppendAllText(FileName, StringToWrite);

                            nameTextBox.Clear();
                            numberTextBox.Clear();
                            hoursTextBox.Clear();
                        }
         
                    }
                    catch(FormatException e)
                    {
                        MessageBox.Show("Please enter a number for the hours ");
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
            OutputForm form = new OutputForm("Changeme.txt");
            form.Show();
            this.Close();
           
        
        }

   
    }
}
