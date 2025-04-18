using System;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class StudentForm : Form
    {
        public Student Student { get; private set; }
        public StudentForm(Student? student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                textBoxLastName.Text = student.LastName;
                textBoxFirstName.Text = student.FirstName;
                textBoxMiddleName.Text = student.MiddleName;
                numericUpDownCourse.Value = student.Course;
                textBoxGroup.Text = student.Group;
                dateTimePickerBirth.Value = student.BirthDate;
                textBoxEmail.Text = student.Email;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var s = new Student
            {
                LastName = textBoxLastName.Text.Trim(),
                FirstName = textBoxFirstName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                Course = (int)numericUpDownCourse.Value,
                Group = textBoxGroup.Text.Trim(),
                BirthDate = dateTimePickerBirth.Value.Date,
                Email = textBoxEmail.Text.Trim()
            };
            if (!StudentValidator.Validate(s, out string error))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Фокус на первое невалидное поле
                if (error.Contains("фамилию")) textBoxLastName.Focus();
                else if (error.Contains("имя")) textBoxFirstName.Focus();
                else if (error.Contains("отчество")) textBoxMiddleName.Focus();
                else if (error.Contains("Курс")) numericUpDownCourse.Focus();
                else if (error.Contains("группу")) textBoxGroup.Focus();
                else if (error.Contains("Дата рождения")) dateTimePickerBirth.Focus();
                else if (error.Contains("почту")) textBoxEmail.Focus();
                return;
            }
            Student = s;
            DialogResult = DialogResult.OK;
        }
    }
} 