namespace tinycollege
{
    partial class DeptInfo
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
            CrossBtn = new Button();
            textBox6 = new TextBox();
            ProfnumBtn = new TextBox();
            ScBtn = new TextBox();
            deptnameBtn = new TextBox();
            DeptcodeBtn = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnEdit = new Button();
            BtnCreate = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox5 = new TextBox();
            RoomBtn = new Button();
            ProfessorBtn = new Button();
            SemesterBtn = new Button();
            DepartmentBtn = new Button();
            BuildingBtn = new Button();
            CourseBtn = new Button();
            StudentBtn = new Button();
            ClassBtn = new Button();
            SchoolBtn = new Button();
            BtnEnrollment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(916, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(75, 23);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(449, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 51;
            textBox6.Text = "Department Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(28, 425);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(256, 16);
            ProfnumBtn.TabIndex = 49;
            ProfnumBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // ScBtn
            // 
            ScBtn.BorderStyle = BorderStyle.None;
            ScBtn.Location = new Point(28, 365);
            ScBtn.Name = "ScBtn";
            ScBtn.Size = new Size(256, 16);
            ScBtn.TabIndex = 48;
            ScBtn.TextChanged += ScBtn_TextChanged;
            // 
            // deptnameBtn
            // 
            deptnameBtn.BorderStyle = BorderStyle.None;
            deptnameBtn.Location = new Point(28, 309);
            deptnameBtn.Name = "deptnameBtn";
            deptnameBtn.Size = new Size(256, 16);
            deptnameBtn.TabIndex = 47;
            deptnameBtn.TextChanged += deptnameBtn_TextChanged;
            // 
            // DeptcodeBtn
            // 
            DeptcodeBtn.BorderStyle = BorderStyle.None;
            DeptcodeBtn.Location = new Point(28, 247);
            DeptcodeBtn.Name = "DeptcodeBtn";
            DeptcodeBtn.Size = new Size(256, 16);
            DeptcodeBtn.TabIndex = 46;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(28, 399);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 20);
            textBox4.TabIndex = 44;
            textBox4.Text = "Prof Num:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(28, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 43;
            textBox3.Text = "Department Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(28, 339);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 20);
            textBox2.TabIndex = 42;
            textBox2.Text = "School Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(773, 526);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 28);
            BtnDelete.TabIndex = 40;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(633, 526);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 28);
            BtnUpdate.TabIndex = 39;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(475, 526);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 28);
            BtnEdit.TabIndex = 38;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(323, 526);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(95, 28);
            BtnCreate.TabIndex = 37;
            BtnCreate.Text = "CREATE";
            BtnCreate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(28, 283);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 20);
            textBox1.TabIndex = 41;
            textBox1.Text = "Department Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(323, 192);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(586, 304);
            dataGridViewBtn.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(323, 170);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search here";
            textBox5.Size = new Size(586, 16);
            textBox5.TabIndex = 52;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomBtn.Location = new Point(799, 42);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(131, 26);
            RoomBtn.TabIndex = 53;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfessorBtn.Location = new Point(610, 89);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 99;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SemesterBtn.Location = new Point(610, 42);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 100;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentBtn.Location = new Point(414, 42);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 101;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuildingBtn.Location = new Point(414, 89);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 102;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.FlatStyle = FlatStyle.Popup;
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseBtn.Location = new Point(250, 42);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 103;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentBtn.Location = new Point(250, 89);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 104;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassBtn.Location = new Point(81, 42);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 105;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            ClassBtn.Click += ClassBtn_Click;
            // 
            // SchoolBtn
            // 
            SchoolBtn.FlatStyle = FlatStyle.Popup;
            SchoolBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchoolBtn.Location = new Point(81, 89);
            SchoolBtn.Name = "SchoolBtn";
            SchoolBtn.Size = new Size(102, 26);
            SchoolBtn.TabIndex = 106;
            SchoolBtn.Text = "SCHOOL";
            SchoolBtn.UseVisualStyleBackColor = true;
            SchoolBtn.Click += SchoolBtn_Click;
            // 
            // BtnEnrollment
            // 
            BtnEnrollment.FlatStyle = FlatStyle.Popup;
            BtnEnrollment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BtnEnrollment.Location = new Point(799, 89);
            BtnEnrollment.Name = "BtnEnrollment";
            BtnEnrollment.Size = new Size(131, 26);
            BtnEnrollment.TabIndex = 127;
            BtnEnrollment.Text = "ENROLLMENT";
            BtnEnrollment.UseVisualStyleBackColor = true;
            BtnEnrollment.Click += BtnEnrollment_Click;
            // 
            // DeptInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(BtnEnrollment);
            Controls.Add(SchoolBtn);
            Controls.Add(ClassBtn);
            Controls.Add(StudentBtn);
            Controls.Add(CourseBtn);
            Controls.Add(BuildingBtn);
            Controls.Add(DepartmentBtn);
            Controls.Add(SemesterBtn);
            Controls.Add(ProfessorBtn);
            Controls.Add(RoomBtn);
            Controls.Add(textBox5);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(ScBtn);
            Controls.Add(deptnameBtn);
            Controls.Add(DeptcodeBtn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeptInfo";
            Text = "DeptInfo";
            Load += DeptInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox ProfnumBtn;
        private TextBox ScBtn;
        private TextBox deptnameBtn;
        private TextBox DeptcodeBtn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnEdit;
        private Button BtnCreate;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox5;
        private Button RoomBtn;
        private Button ProfessorBtn;
        private Button SemesterBtn;
        private Button DepartmentBtn;
        private Button BuildingBtn;
        private Button CourseBtn;
        private Button StudentBtn;
        private Button ClassBtn;
        private Button SchoolBtn;
        private Button BtnEnrollment;
    }
}