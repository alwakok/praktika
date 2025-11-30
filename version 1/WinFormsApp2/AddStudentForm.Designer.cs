namespace WinFormsApp2
{
    partial class AddStudentForm
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
            saveButton = new Button();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            classTextBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(72, 225);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(47, 143);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(153, 143);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 2;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // classTextBox
            // 
            classTextBox.Location = new Point(259, 143);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(100, 23);
            classTextBox.TabIndex = 3;
            classTextBox.TextChanged += classTextBox_TextChanged;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(365, 143);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(200, 23);
            birthDatePicker.TabIndex = 4;
            birthDatePicker.ValueChanged += birthDatePicker_ValueChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(153, 225);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Выйти";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(birthDatePicker);
            Controls.Add(classTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(saveButton);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox classTextBox;
        private DateTimePicker birthDatePicker;
        private Button cancelButton;
    }
}