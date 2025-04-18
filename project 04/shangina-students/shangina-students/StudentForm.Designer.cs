namespace StudentManager
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(140, 15);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 27);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(140, 55);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 27);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(140, 95);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(200, 27);
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(140, 135);
            this.numericUpDownCourse.Minimum = 1;
            this.numericUpDownCourse.Maximum = 6;
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(80, 27);
            this.numericUpDownCourse.Value = 1;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(140, 175);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(200, 27);
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(140, 215);
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.MinDate = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.MaxDate = System.DateTime.Today;
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 27);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(140, 255);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 27);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(60, 300);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 35);
            this.buttonOK.Text = "OK";
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(200, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 35);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.Text = "Курс:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.Text = "Группа:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 215);
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 255);
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.Text = "Email:";
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 360);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
} 