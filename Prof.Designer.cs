﻿namespace tinycollege
{
    partial class Profes
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
            components = new System.ComponentModel.Container();
            CrossBtn = new Button();
            CreateBtn = new Button();
            EditBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            EIDBtn = new TextBox();
            StNBtn = new TextBox();
            CCBtn = new TextBox();
            EnGBtn = new TextBox();
            textBox6 = new TextBox();
            ClassBtn = new Button();
            bindingSource1 = new BindingSource(components);
            ProfessorBtn = new Button();
            DepartmentBtn = new Button();
            SemesterBtn = new Button();
            CourseBtn = new Button();
            StudentBtn = new Button();
            BuildingBtn = new Button();
            RoomBtn = new Button();
            SchoolBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            xBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(1073, 27);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(75, 23);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(369, 533);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(101, 25);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(507, 534);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(110, 25);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(661, 534);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(95, 25);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(801, 533);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(95, 25);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            textBox1.Location = new Point(47, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 17);
            textBox1.TabIndex = 8;
            textBox1.Text = "Enrollment ID:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox2.Location = new Point(45, 320);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "Class Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox3.Location = new Point(47, 433);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 20);
            textBox3.TabIndex = 10;
            textBox3.Text = "Enrollment Grade:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox4.Location = new Point(45, 375);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 20);
            textBox4.TabIndex = 11;
            textBox4.Text = "Enrollment Date:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox5.Location = new Point(47, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 20);
            textBox5.TabIndex = 12;
            textBox5.Text = "Student Number:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // EIDBtn
            // 
            EIDBtn.BorderStyle = BorderStyle.None;
            EIDBtn.Location = new Point(47, 244);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(248, 16);
            EIDBtn.TabIndex = 13;
            // 
            // StNBtn
            // 
            StNBtn.Location = new Point(47, 292);
            StNBtn.Name = "StNBtn";
            StNBtn.Size = new Size(248, 23);
            StNBtn.TabIndex = 14;
            // 
            // CCBtn
            // 
            CCBtn.Location = new Point(47, 346);
            CCBtn.Name = "CCBtn";
            CCBtn.Size = new Size(248, 23);
            CCBtn.TabIndex = 15;
            // 
            // EnGBtn
            // 
            EnGBtn.Location = new Point(47, 459);
            EnGBtn.Name = "EnGBtn";
            EnGBtn.Size = new Size(250, 23);
            EnGBtn.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(507, 149);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(249, 33);
            textBox6.TabIndex = 18;
            textBox6.Text = "Enrollment";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ClassBtn.Location = new Point(72, 59);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 19;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            ClassBtn.Click += ClassBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ProfessorBtn.Location = new Point(586, 59);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 20;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            DepartmentBtn.Location = new Point(386, 59);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 21;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SemesterBtn.Location = new Point(586, 103);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 22;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.FlatStyle = FlatStyle.Popup;
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            CourseBtn.Location = new Point(228, 103);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 23;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            StudentBtn.Location = new Point(228, 59);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 24;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BuildingBtn.Location = new Point(386, 103);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 25;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            RoomBtn.Location = new Point(775, 83);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(137, 26);
            RoomBtn.TabIndex = 26;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click_1;
            // 
            // SchoolBtn
            // 
            SchoolBtn.FlatStyle = FlatStyle.Popup;
            SchoolBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SchoolBtn.Location = new Point(72, 103);
            SchoolBtn.Name = "SchoolBtn";
            SchoolBtn.Size = new Size(102, 26);
            SchoolBtn.TabIndex = 28;
            SchoolBtn.Text = "SCHOOL";
            SchoolBtn.UseVisualStyleBackColor = true;
            SchoolBtn.Click += SchoolBtn_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 404);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(369, 199);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Search here";
            textBox7.Size = new Size(527, 16);
            textBox7.TabIndex = 30;
            // 
            // xBtn
            // 
            xBtn.FlatStyle = FlatStyle.Popup;
            xBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xBtn.Location = new Point(917, 0);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(75, 23);
            xBtn.TabIndex = 76;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = true;
            xBtn.Click += xBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 237);
            dataGridView1.TabIndex = 104;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Profes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(dataGridView1);
            Controls.Add(xBtn);
            Controls.Add(textBox7);
            Controls.Add(dateTimePicker1);
            Controls.Add(SchoolBtn);
            Controls.Add(RoomBtn);
            Controls.Add(BuildingBtn);
            Controls.Add(StudentBtn);
            Controls.Add(CourseBtn);
            Controls.Add(SemesterBtn);
            Controls.Add(DepartmentBtn);
            Controls.Add(ProfessorBtn);
            Controls.Add(ClassBtn);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(EnGBtn);
            Controls.Add(CCBtn);
            Controls.Add(StNBtn);
            Controls.Add(EIDBtn);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(EditBtn);
            Controls.Add(CreateBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profes";
            Text = "Prof";
            Load += Prof_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CrossBtn;
        private Button CreateBtn;
        private Button EditBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox EIDBtn;
        private TextBox StNBtn;
        private TextBox CCBtn;
        private TextBox EnGBtn;
        private TextBox textBox6;
        private Button ClassBtn;
        private BindingSource bindingSource1;
        private Button ProfessorBtn;
        private Button DepartmentBtn;
        private Button SemesterBtn;
        private Button CourseBtn;
        private Button StudentBtn;
        private Button BuildingBtn;
        private Button RoomBtn;
        private Button SchoolBtn;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private Button xBtn;
        private DataGridView dataGridView1;
    }
}