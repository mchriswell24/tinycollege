﻿namespace tinycollege
{
    partial class SchoolInfo
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
            textBox6 = new TextBox();
            ProfnumBtn = new TextBox();
            SchoolnameBtn = new TextBox();
            SchoolcodeBtn = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnEdit = new Button();
            BtnCreate = new Button();
            textBox1 = new TextBox();
            CrossBtn = new Button();
            textBox4 = new TextBox();
            RoomBtn = new Button();
            SemesterBtn = new Button();
            ProfessorBtn = new Button();
            DepartmentBtn = new Button();
            BuildingBtn = new Button();
            StudentBtn = new Button();
            CourseBtn = new Button();
            ClassBtn = new Button();
            BtnEnrollment = new Button();
            dataGridView8 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(466, 127);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 79;
            textBox6.Text = "School Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(42, 385);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(241, 16);
            ProfnumBtn.TabIndex = 78;
            ProfnumBtn.TextChanged += ProfnumBtn_TextChanged;
            // 
            // SchoolnameBtn
            // 
            SchoolnameBtn.BorderStyle = BorderStyle.None;
            SchoolnameBtn.Location = new Point(42, 321);
            SchoolnameBtn.Name = "SchoolnameBtn";
            SchoolnameBtn.Size = new Size(241, 16);
            SchoolnameBtn.TabIndex = 77;
            SchoolnameBtn.TextChanged += SchoolnameBtn_TextChanged;
            // 
            // SchoolcodeBtn
            // 
            SchoolcodeBtn.BorderStyle = BorderStyle.None;
            SchoolcodeBtn.Location = new Point(42, 261);
            SchoolcodeBtn.Name = "SchoolcodeBtn";
            SchoolcodeBtn.Size = new Size(241, 16);
            SchoolcodeBtn.TabIndex = 76;
            SchoolcodeBtn.TextChanged += SchoolcodeBtn_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 75;
            textBox3.Text = "School Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(42, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 20);
            textBox2.TabIndex = 74;
            textBox2.Text = "Prof Num:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(791, 495);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 33);
            BtnDelete.TabIndex = 72;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += DeleteBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(639, 495);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 33);
            BtnUpdate.TabIndex = 71;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(489, 495);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 33);
            BtnEdit.TabIndex = 70;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += ReadBtn_Click;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(338, 495);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(95, 33);
            BtnCreate.TabIndex = 69;
            BtnCreate.Text = "CREATE";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(42, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 20);
            textBox1.TabIndex = 73;
            textBox1.Text = "School  Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(917, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(75, 23);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(338, 173);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(548, 16);
            textBox4.TabIndex = 80;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomBtn.Location = new Point(802, 34);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(131, 26);
            RoomBtn.TabIndex = 114;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SemesterBtn.Location = new Point(604, 34);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 116;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfessorBtn.Location = new Point(604, 87);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 117;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentBtn.Location = new Point(405, 34);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 118;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildingBtn.Location = new Point(405, 87);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 119;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentBtn.Location = new Point(244, 34);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 120;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.FlatStyle = FlatStyle.Popup;
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseBtn.Location = new Point(244, 87);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 121;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassBtn.Location = new Point(85, 34);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 122;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            ClassBtn.Click += ClassBtn_Click;
            // 
            // BtnEnrollment
            // 
            BtnEnrollment.FlatStyle = FlatStyle.Popup;
            BtnEnrollment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BtnEnrollment.Location = new Point(76, 87);
            BtnEnrollment.Name = "BtnEnrollment";
            BtnEnrollment.Size = new Size(122, 26);
            BtnEnrollment.TabIndex = 127;
            BtnEnrollment.Text = "ENROLLMENT";
            BtnEnrollment.UseVisualStyleBackColor = true;
            BtnEnrollment.Click += BtnEnrollment_Click;
            // 
            // dataGridView8
            // 
            dataGridView8.BackgroundColor = Color.AntiqueWhite;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(338, 195);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.Size = new Size(548, 265);
            dataGridView8.TabIndex = 128;
            dataGridView8.CellContentClick += dataGridView8_CellContentClick;
            // 
            // SchoolInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(dataGridView8);
            Controls.Add(BtnEnrollment);
            Controls.Add(ClassBtn);
            Controls.Add(CourseBtn);
            Controls.Add(StudentBtn);
            Controls.Add(BuildingBtn);
            Controls.Add(DepartmentBtn);
            Controls.Add(ProfessorBtn);
            Controls.Add(SemesterBtn);
            Controls.Add(RoomBtn);
            Controls.Add(textBox4);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(SchoolnameBtn);
            Controls.Add(SchoolcodeBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SchoolInfo";
            Text = "Schools";
            Load += Schools_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private TextBox ProfnumBtn;
        private TextBox SchoolnameBtn;
        private TextBox SchoolcodeBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnEdit;
        private Button BtnCreate;
        private TextBox textBox1;
        private Button CrossBtn;
        private TextBox textBox4;
        private Button RoomBtn;
        private Button SemesterBtn;
        private Button ProfessorBtn;
        private Button DepartmentBtn;
        private Button BuildingBtn;
        private Button StudentBtn;
        private Button CourseBtn;
        private Button ClassBtn;
        private Button BtnEnrollment;
        private DataGridView dataGridView8;
    }
}