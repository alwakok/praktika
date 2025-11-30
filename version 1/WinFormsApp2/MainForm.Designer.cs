namespace WinFormsApp2
{
    partial class MainForm
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
            studentsListBox = new ListBox();
            subjectComboBox = new ComboBox();
            gradesDataGridView = new DataGridView();
            studentInfoLabel = new Label();
            averageGradeLabel = new Label();
            addGradeButton = new Button();
            addStudentButton = new Button();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.Location = new Point(12, 12);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(254, 334);
            studentsListBox.TabIndex = 0;
            studentsListBox.SelectedIndexChanged += studentsListBox_SelectedIndexChanged;
            // 
            // subjectComboBox
            // 
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Location = new Point(399, 352);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(121, 23);
            subjectComboBox.TabIndex = 1;
            subjectComboBox.SelectedIndexChanged += subjectComboBox_SelectedIndexChanged;
            // 
            // gradesDataGridView
            // 
            gradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesDataGridView.Location = new Point(272, 12);
            gradesDataGridView.Name = "gradesDataGridView";
            gradesDataGridView.Size = new Size(516, 334);
            gradesDataGridView.TabIndex = 2;
            gradesDataGridView.CellContentClick += gradesDataGridView_CellContentClick;
            // 
            // studentInfoLabel
            // 
            studentInfoLabel.AutoSize = true;
            studentInfoLabel.Location = new Point(399, 394);
            studentInfoLabel.Name = "studentInfoLabel";
            studentInfoLabel.Size = new Size(38, 15);
            studentInfoLabel.TabIndex = 3;
            studentInfoLabel.Text = "label1";
            studentInfoLabel.Click += studentInfoLabel_Click;
            // 
            // averageGradeLabel
            // 
            averageGradeLabel.AutoSize = true;
            averageGradeLabel.Location = new Point(272, 394);
            averageGradeLabel.Name = "averageGradeLabel";
            averageGradeLabel.Size = new Size(38, 15);
            averageGradeLabel.TabIndex = 4;
            averageGradeLabel.Text = "label1";
            averageGradeLabel.Click += averageGradeLabel_Click;
            // 
            // addGradeButton
            // 
            addGradeButton.Location = new Point(93, 371);
            addGradeButton.Name = "addGradeButton";
            addGradeButton.Size = new Size(75, 38);
            addGradeButton.TabIndex = 5;
            addGradeButton.Text = "добавить оценку";
            addGradeButton.UseVisualStyleBackColor = true;
            addGradeButton.Click += addGradeButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(12, 371);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(75, 38);
            addStudentButton.TabIndex = 6;
            addStudentButton.Text = "добавить студента";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(272, 352);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(121, 23);
            searchTextBox.TabIndex = 7;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchTextBox);
            Controls.Add(addStudentButton);
            Controls.Add(addGradeButton);
            Controls.Add(averageGradeLabel);
            Controls.Add(studentInfoLabel);
            Controls.Add(gradesDataGridView);
            Controls.Add(subjectComboBox);
            Controls.Add(studentsListBox);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox studentsListBox;
        private ComboBox subjectComboBox;
        private DataGridView gradesDataGridView;
        private Label studentInfoLabel;
        private Label averageGradeLabel;
        private Button addGradeButton;
        private Button addStudentButton;
        private TextBox searchTextBox;
    }
}