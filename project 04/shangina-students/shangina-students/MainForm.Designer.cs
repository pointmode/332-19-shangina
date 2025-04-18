namespace StudentManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCourseFilter;
        private System.Windows.Forms.ComboBox comboBoxGroupFilter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelSearch;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCourseFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxGroupFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowTemplate.Height = 29;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 320);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 400);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(108, 400);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 35);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(204, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(300, 400);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(90, 35);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Импорт";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(396, 400);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(90, 35);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(492, 400);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 35);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxCourseFilter
            // 
            this.comboBoxCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourseFilter.FormattingEnabled = true;
            this.comboBoxCourseFilter.Location = new System.Drawing.Point(80, 20);
            this.comboBoxCourseFilter.Name = "comboBoxCourseFilter";
            this.comboBoxCourseFilter.Size = new System.Drawing.Size(80, 28);
            this.comboBoxCourseFilter.TabIndex = 7;
            // 
            // comboBoxGroupFilter
            // 
            this.comboBoxGroupFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupFilter.FormattingEnabled = true;
            this.comboBoxGroupFilter.Location = new System.Drawing.Point(240, 20);
            this.comboBoxGroupFilter.Name = "comboBoxGroupFilter";
            this.comboBoxGroupFilter.Size = new System.Drawing.Size(100, 28);
            this.comboBoxGroupFilter.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(480, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Поиск по фамилии";
            this.textBoxSearch.Size = new System.Drawing.Size(180, 27);
            this.textBoxSearch.TabIndex = 9;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 23);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(45, 20);
            this.labelCourse.TabIndex = 10;
            this.labelCourse.Text = "Курс:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(170, 23);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 20);
            this.labelGroup.TabIndex = 11;
            this.labelGroup.Text = "Группа:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(400, 23);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(74, 20);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Фамилия:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxGroupFilter);
            this.Controls.Add(this.comboBoxCourseFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "MainForm";
            this.Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
} 