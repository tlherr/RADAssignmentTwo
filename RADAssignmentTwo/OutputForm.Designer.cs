namespace RADAssignmentTwo
{
    partial class OutputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.weeklyPayTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.weeklyPayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(104, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(213, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Employee Information";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(190, 81);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(190, 127);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNumberTextBox.TabIndex = 2;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(190, 181);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(55, 20);
            this.hoursWorkedTextBox.TabIndex = 3;
            // 
            // weeklyPayTextBox
            // 
            this.weeklyPayTextBox.Location = new System.Drawing.Point(190, 231);
            this.weeklyPayTextBox.Name = "weeklyPayTextBox";
            this.weeklyPayTextBox.Size = new System.Drawing.Size(55, 20);
            this.weeklyPayTextBox.TabIndex = 4;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(84, 286);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(261, 285);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(52, 87);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 7;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Location = new System.Drawing.Point(52, 134);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.employeeNumberLabel.TabIndex = 8;
            this.employeeNumberLabel.Text = "Employee Number";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(52, 188);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.hoursWorkedLabel.TabIndex = 9;
            this.hoursWorkedLabel.Text = "Hours Worked";
            // 
            // weeklyPayLabel
            // 
            this.weeklyPayLabel.AutoSize = true;
            this.weeklyPayLabel.Location = new System.Drawing.Point(52, 238);
            this.weeklyPayLabel.Name = "weeklyPayLabel";
            this.weeklyPayLabel.Size = new System.Drawing.Size(64, 13);
            this.weeklyPayLabel.TabIndex = 10;
            this.weeklyPayLabel.Text = "Weekly Pay";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(243, 329);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 16);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Thomas Herr | Nathan Siu";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 354);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.weeklyPayLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.weeklyPayTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox weeklyPayTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label weeklyPayLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}