using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private SchoolContext context;
        private BindingSource studentsBindingSource;
        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDatabase()
        {
            context = new SchoolContext();
            context.Database.EnsureCreated();
        }
        private void InitializeData()
        {
            studentsBindingSource = new BindingSource();
            LoadStudents();
            LoadSubjects();
            SetupDataGrids();
        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedItem != null)
            {
                var student = (Student)studentsListBox.SelectedItem;
                var studentId = student.Id;
                LoadStudentGrades(studentId);
                UpdateStudentInfo(studentId);
            }
        }
        private void LoadStudents()
        {
            var students = context.Students
                .Include(s => s.Grades)
                .ThenInclude(g => g.Subject)
                .ToList();

            studentsBindingSource.DataSource = students;
            studentsListBox.DataSource = studentsBindingSource;
            studentsListBox.DisplayMember = "FullName";
            studentsListBox.ValueMember = "Id";
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedItem != null && subjectComboBox.SelectedItem != null)
            {
                var student = (Student)studentsListBox.SelectedItem;
                var selectedSubject = (Subject)subjectComboBox.SelectedItem;

                FilterStudentGradesBySubject(student.Id, selectedSubject.Id);
            }
        }
        private void FilterStudentGradesBySubject(int studentId, int subjectId)
        {
            var grades = context.Grades
                .Where(g => g.StudentId == studentId && g.SubjectId == subjectId)
                .Include(g => g.Subject)
                .Select(g => new
                {
                    Предмет = g.Subject.Name,
                    Оценка = g.Mark,
                    Дата = g.Date,
                    Описание = g.Description
                })
                .ToList();

            gradesDataGridView.DataSource = grades;
        }
        private void LoadSubjects()
        {
            var subjects = context.Subjects.ToList();
            subjectComboBox.DataSource = subjects;
            subjectComboBox.DisplayMember = "Name";
            subjectComboBox.ValueMember = "Id";
        }

        private void gradesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupDataGrids()
        {
            // Настройка DataGridView для оценок
            gradesDataGridView.AutoGenerateColumns = false;

            // Очищаем колонки только если они уже существуют
            if (gradesDataGridView.Columns.Count == 0)
            {
                gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SubjectName",
                    HeaderText = "Предмет",
                    ReadOnly = true
                });
                gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Mark",
                    HeaderText = "Оценка",
                    ReadOnly = true
                });
                gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Date",
                    HeaderText = "Дата",
                    ReadOnly = true
                });
                gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Description",
                    HeaderText = "Описание",
                    ReadOnly = true
                });
            }
        }
        private void LoadStudentGrades(int studentId)
        {
            var grades = context.Grades
                .Where(g => g.StudentId == studentId)
                .Include(g => g.Subject)
                .Select(g => new
                {
                    Предмет = g.Subject.Name,
                    Оценка = g.Mark,
                    Дата = g.Date,
                    Описание = g.Description
                })
                .ToList();

            gradesDataGridView.DataSource = grades;
        }

        private void studentInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void averageGradeLabel_Click(object sender, EventArgs e)
        {

        }
        private void UpdateStudentInfo(int studentId)
        {
            var student = context.Students.Find(studentId);
            if (student != null)
            {
                studentInfoLabel.Text = $"Класс: {student.Class} | Дата рождения: {student.BirthDate:dd.MM.yyyy}";

                // Расчет средней оценки
                var averageGrade = context.Grades
                    .Where(g => g.StudentId == studentId)
                    .Average(g => (double?)g.Mark) ?? 0;
                averageGradeLabel.Text = $"Средний балл: {averageGrade:F2}";
            }
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента!");
                return;
            }

            using (var form = new AddGradeForm())
            {
                form.Subjects = context.Subjects.ToList();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var student = (Student)studentsListBox.SelectedItem;
                    var grade = new Grade
                    {
                        StudentId = student.Id, // Используем student.Id вместо приведения SelectedValue
                        SubjectId = form.SelectedSubjectId,
                        Mark = form.Mark,
                        Date = form.Date,
                        Description = form.Description
                    };

                    context.Grades.Add(grade);
                    context.SaveChanges();

                    LoadStudentGrades(student.Id);
                    UpdateStudentInfo(student.Id);
                }
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (var form = new AddStudentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    context.Students.Add(form.Student);
                    context.SaveChanges();
                    LoadStudents();
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.ToLower();
            var filteredStudents = context.Students
                .Where(s => s.FirstName.ToLower().Contains(searchText) ||
                           s.LastName.ToLower().Contains(searchText) ||
                           s.Class.ToLower().Contains(searchText))
                .ToList();

            studentsBindingSource.DataSource = filteredStudents;
        }

        /*private void clearDatabaseButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы уверены, что хотите полностью очистить базу данных? Все данные будут удалены!",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                   
                    context.Database.ExecuteSqlRaw("DELETE FROM Grades");
                    context.Database.ExecuteSqlRaw("DELETE FROM Students");
                    context.Database.ExecuteSqlRaw("DELETE FROM Subjects");

                    
                    context.Subjects.AddRange(new[]
                    {
                new Subject { Name = "Математика" },
                new Subject { Name = "Русский язык" },
                new Subject { Name = "Литература" },
                new Subject { Name = "История" },
                new Subject { Name = "Физика" }
            });

                    context.SaveChanges();

                    
                    LoadStudents();
                    gradesDataGridView.DataSource = null;

                    MessageBox.Show("База данных успешно очищена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при очистке базы: {ex.Message}");
                }
            }
        }*/
    }
}

