using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AddStudentForm : Form
    {
        public Student Student { get; private set; }

        public AddStudentForm()
        {
            InitializeComponent();
            Student = new Student();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Student.FirstName = firstNameTextBox.Text;
                Student.LastName = lastNameTextBox.Text;
                Student.Class = classTextBox.Text;
                Student.BirthDate = birthDatePicker.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(classTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
