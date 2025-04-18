using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace StudentManager
{
    public partial class MainForm : Form
    {
        private List<Student> students = new();
        private List<Student> filtered = new();
        private bool isModified = false;
        private string dataFile = "students.json";
        private int sortColumnIndex = -1;
        private bool sortAscending = true;
        public MainForm()
        {
            InitializeComponent();
            InitUI();
            LoadSettings();
            LoadData();
            UpdateFilters();
            ApplyFilter();
        }

        private void InitUI()
        {
            // Настройка DataGridView
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Фамилия", DataPropertyName = "LastName" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Имя", DataPropertyName = "FirstName" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Отчество", DataPropertyName = "MiddleName" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Курс", DataPropertyName = "Course" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Группа", DataPropertyName = "Group" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дата рождения", DataPropertyName = "BirthDate" });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dataGridViewStudents.DataSource = students;
            dataGridViewStudents.CellDoubleClick += DataGridViewStudents_CellDoubleClick;
            dataGridViewStudents.ColumnHeaderMouseClick += DataGridViewStudents_ColumnHeaderMouseClick;
            dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;

            // Курс
            comboBoxCourseFilter.Items.Add("Все");
            for (int i = 1; i <= 6; i++) comboBoxCourseFilter.Items.Add(i.ToString());
            comboBoxCourseFilter.SelectedIndex = 0;
            // Группа
            comboBoxGroupFilter.Items.Add("Все");
            comboBoxGroupFilter.SelectedIndex = 0;

            // События
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonImport.Click += ButtonImport_Click;
            buttonExport.Click += ButtonExport_Click;
            buttonSave.Click += ButtonSave_Click;
            comboBoxCourseFilter.SelectedIndexChanged += FilterChanged;
            comboBoxGroupFilter.SelectedIndexChanged += FilterChanged;
            textBoxSearch.TextChanged += FilterChanged;
            this.FormClosing += MainForm_FormClosing;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void LoadSettings()
        {
            if (File.Exists("appsettings.json"))
            {
                var json = File.ReadAllText("appsettings.json");
                using var doc = JsonDocument.Parse(json);
                if (doc.RootElement.TryGetProperty("DataFile", out var el))
                    dataFile = el.GetString() ?? dataFile;
            }
        }

        private void LoadData()
        {
            students = StudentRepository.LoadFromJson(dataFile);
        }

        private void SaveData()
        {
            StudentRepository.SaveToJson(dataFile, students);
            isModified = false;
        }

        private void UpdateFilters()
        {
            var groups = students.Select(s => s.Group).Distinct().OrderBy(g => g).ToList();
            string prev = comboBoxGroupFilter.SelectedItem?.ToString() ?? "Все";
            comboBoxGroupFilter.Items.Clear();
            comboBoxGroupFilter.Items.Add("Все");
            foreach (var g in groups)
                if (!string.IsNullOrWhiteSpace(g)) comboBoxGroupFilter.Items.Add(g);
            int idx = comboBoxGroupFilter.Items.IndexOf(prev);
            comboBoxGroupFilter.SelectedIndex = idx >= 0 ? idx : 0;
        }

        private void ApplyFilter()
        {
            IEnumerable<Student> query = students;
            if (comboBoxCourseFilter.SelectedIndex > 0)
            {
                int course = int.Parse(comboBoxCourseFilter.SelectedItem.ToString()!);
                query = query.Where(s => s.Course == course);
            }
            if (comboBoxGroupFilter.SelectedIndex > 0)
            {
                string group = comboBoxGroupFilter.SelectedItem.ToString()!;
                query = query.Where(s => s.Group == group);
            }
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                string search = textBoxSearch.Text.Trim().ToLower();
                query = query.Where(s => s.LastName.ToLower().Contains(search));
            }
            filtered = query.ToList();
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = filtered;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (students.Any(st => st.Email == form.Student.Email))
                {
                    MessageBox.Show("Студент с такой почтой уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                students.Add(form.Student);
                isModified = true;
                UpdateFilters();
                ApplyFilter();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0) return;
            var idx = dataGridViewStudents.SelectedRows[0].Index;
            if (idx < 0 || idx >= filtered.Count) return;
            var student = filtered[idx];
            var form = new StudentForm(student);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var orig = students.First(s => s == student);
                orig.LastName = form.Student.LastName;
                orig.FirstName = form.Student.FirstName;
                orig.MiddleName = form.Student.MiddleName;
                orig.Course = form.Student.Course;
                orig.Group = form.Student.Group;
                orig.BirthDate = form.Student.BirthDate;
                orig.Email = form.Student.Email;
                isModified = true;
                UpdateFilters();
                ApplyFilter();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0) return;
            var idx = dataGridViewStudents.SelectedRows[0].Index;
            if (idx < 0 || idx >= filtered.Count) return;
            var student = filtered[idx];
            if (MessageBox.Show($"Удалить {student.LastName} {student.FirstName}?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                students.Remove(student);
                isModified = true;
                UpdateFilters();
                ApplyFilter();
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "CSV файлы|*.csv" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var imported = CsvHelper.ImportFromCsv(ofd.FileName);
                int added = 0;
                foreach (var s in imported)
                {
                    if (!students.Any(st => st.Email == s.Email))
                    {
                        students.Add(s);
                        added++;
                    }
                }
                if (added == 0)
                    MessageBox.Show("Нет новых студентов для импорта.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isModified = true;
                UpdateFilters();
                ApplyFilter();
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog { Filter = "CSV файлы|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CsvHelper.ExportToCsv(sfd.FileName, filtered);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                var res = MessageBox.Show("Есть несохранённые изменения. Сохранить?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel) e.Cancel = true;
                else if (res == DialogResult.Yes) SaveData();
            }
        }

        private void DataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewStudents.SelectedRows.Count > 0;
            buttonEdit.Enabled = hasSelection;
            buttonDelete.Enabled = hasSelection;
        }

        private void DataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                ButtonEdit_Click(sender, e);
        }

        private void DataGridViewStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == sortColumnIndex)
                sortAscending = !sortAscending;
            else
            {
                sortColumnIndex = e.ColumnIndex;
                sortAscending = true;
            }
            string prop = dataGridViewStudents.Columns[sortColumnIndex].DataPropertyName;
            if (sortAscending)
                filtered = filtered.OrderBy(s => GetPropertyValue(s, prop)).ToList();
            else
                filtered = filtered.OrderByDescending(s => GetPropertyValue(s, prop)).ToList();
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = filtered;
        }

        private object? GetPropertyValue(Student s, string prop)
        {
            return typeof(Student).GetProperty(prop)?.GetValue(s);
        }
    }
} 