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

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string FileName = "EmployeeInformation.txt";
            
            
            
                if (nameTextBox.Text != String.Empty && numberTextBox.Text != String.Empty && hoursTextBox.Text != String.Empty)
                {
                    try
                    {
                        int hours = Int32.Parse(hoursTextBox.Text);
                         string StringToWrite = nameTextBox.Text + "," + numberTextBox.Text + "," +  hours.ToString();
                        
                        File.AppendAllText(FileName, StringToWrite);
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Please enter a number for the hours ");
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show("Please Fill Out all the required fields");
                }
         
           

            
        }

   
    }
}
