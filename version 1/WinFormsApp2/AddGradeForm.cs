using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AddGradeForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Subject> Subjects { get; set; }
        public int SelectedSubjectId { get; private set; }
        public int Mark { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }

        public AddGradeForm()
        {
            InitializeComponent();
            Date = DateTime.Now;
            datePicker.Value = Date;
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            InitializeSubjectsComboBox();
        }

        private void InitializeSubjectsComboBox()
        {
            if (Subjects != null && Subjects.Count > 0)
            {
                subjectComboBox.DataSource = Subjects;
                subjectComboBox.DisplayMember = "Name";
                subjectComboBox.ValueMember = "Id";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SelectedSubjectId = (int)subjectComboBox.SelectedValue;
                Mark = (int)markNumericUpDown.Value;
                Date = datePicker.Value;
                Description = descriptionTextBox.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateForm()
        {
            if (subjectComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите предмет!");
                return false;
            }

            if (markNumericUpDown.Value < 1 || markNumericUpDown.Value > 5)
            {
                MessageBox.Show("Оценка должна быть от 1 до 5!");
                return false;
            }

            return true;
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void markNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}