namespace WinFormsApp2
{
    partial class AddGradeForm
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
            subjectComboBox = new ComboBox();
            markNumericUpDown = new NumericUpDown();
            datePicker = new DateTimePicker();
            descriptionTextBox = new TextBox();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(144, 278);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // subjectComboBox
            // 
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Location = new Point(98, 205);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(121, 23);
            subjectComboBox.TabIndex = 1;
            subjectComboBox.SelectedIndexChanged += subjectComboBox_SelectedIndexChanged;
            // 
            // markNumericUpDown
            // 
            markNumericUpDown.Location = new Point(225, 205);
            markNumericUpDown.Name = "markNumericUpDown";
            markNumericUpDown.Size = new Size(120, 23);
            markNumericUpDown.TabIndex = 2;
            markNumericUpDown.ValueChanged += markNumericUpDown_ValueChanged;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(351, 205);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 3;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(557, 205);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 4;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(351, 276);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 25);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Выйти";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(datePicker);
            Controls.Add(markNumericUpDown);
            Controls.Add(subjectComboBox);
            Controls.Add(saveButton);
            Name = "AddGradeForm";
            Text = "AddGradeForm";
            Load += AddGradeForm_Load;
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private ComboBox subjectComboBox;
        private NumericUpDown markNumericUpDown;
        private DateTimePicker datePicker;
        private TextBox descriptionTextBox;
        private Button cancelButton;
    }
}