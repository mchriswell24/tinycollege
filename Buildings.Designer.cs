﻿namespace tinycollege
{
    partial class Buildings
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
            buildinglocBtn = new TextBox();
            BuildingnameBtn = new TextBox();
            BuildingcodeBtn = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnEdit = new Button();
            BtnCreate = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox4 = new TextBox();
            RoomBtn = new Button();
            SemesterBtn = new Button();
            ProfessorBtn = new Button();
            DepartmentBtn = new Button();
            BuildingBtn = new Button();
            StudentBtn = new Button();
            CourseBtn = new Button();
            SchoolBtn = new Button();
            ClassBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
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
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(453, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 66;
            textBox6.Text = "Building Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // buildinglocBtn
            // 
            buildinglocBtn.BorderStyle = BorderStyle.None;
            buildinglocBtn.Location = new Point(69, 324);
            buildinglocBtn.Name = "buildinglocBtn";
            buildinglocBtn.Size = new Size(253, 16);
            buildinglocBtn.TabIndex = 64;
            // 
            // BuildingnameBtn
            // 
            BuildingnameBtn.BorderStyle = BorderStyle.None;
            BuildingnameBtn.Location = new Point(69, 276);
            BuildingnameBtn.Name = "BuildingnameBtn";
            BuildingnameBtn.Size = new Size(253, 16);
            BuildingnameBtn.TabIndex = 63;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(69, 228);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(253, 16);
            BuildingcodeBtn.TabIndex = 62;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(47, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 60;
            textBox3.Text = "Building Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(57, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 20);
            textBox2.TabIndex = 59;
            textBox2.Text = "Building Location:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(790, 504);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 33);
            BtnDelete.TabIndex = 57;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += DeleteBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(636, 504);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 33);
            BtnUpdate.TabIndex = 56;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(492, 504);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 33);
            BtnEdit.TabIndex = 55;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += ReadBtn_Click;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(352, 504);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(95, 33);
            BtnCreate.TabIndex = 54;
            BtnCreate.Text = "CREATE";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 20);
            textBox1.TabIndex = 58;
            textBox1.Text = "Building Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(352, 187);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(533, 295);
            dataGridViewBtn.TabIndex = 52;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(352, 165);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(533, 16);
            textBox4.TabIndex = 67;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            RoomBtn.Location = new Point(793, 46);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(102, 26);
            RoomBtn.TabIndex = 101;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SemesterBtn.Location = new Point(612, 64);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 102;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ProfessorBtn.Location = new Point(612, 12);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 103;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            DepartmentBtn.Location = new Point(425, 12);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 104;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BuildingBtn.Location = new Point(425, 64);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 105;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            StudentBtn.Location = new Point(267, 12);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 106;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.FlatStyle = FlatStyle.Popup;
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            CourseBtn.Location = new Point(267, 64);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 109;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // SchoolBtn
            // 
            SchoolBtn.FlatStyle = FlatStyle.Popup;
            SchoolBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SchoolBtn.Location = new Point(89, 64);
            SchoolBtn.Name = "SchoolBtn";
            SchoolBtn.Size = new Size(102, 26);
            SchoolBtn.TabIndex = 124;
            SchoolBtn.Text = "SCHOOL";
            SchoolBtn.UseVisualStyleBackColor = true;
            SchoolBtn.Click += SchoolBtn_Click;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ClassBtn.Location = new Point(89, 12);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 125;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            ClassBtn.Click += ClassBtn_Click;
            // 
            // Buildings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(ClassBtn);
            Controls.Add(SchoolBtn);
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
            Controls.Add(buildinglocBtn);
            Controls.Add(BuildingnameBtn);
            Controls.Add(BuildingcodeBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Buildings";
            Text = "Buildings";
            Load += Buildings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox buildinglocBtn;
        private TextBox BuildingnameBtn;
        private TextBox BuildingcodeBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnEdit;
        private Button BtnCreate;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox4;
        private Button RoomBtn;
        private Button SemesterBtn;
        private Button ProfessorBtn;
        private Button DepartmentBtn;
        private Button BuildingBtn;
        private Button StudentBtn;
        private Button CourseBtn;
        private Button SchoolBtn;
        private Button ClassBtn;
    }
}