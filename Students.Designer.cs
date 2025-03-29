namespace tinycollege
{
    partial class StudentsInfo
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
            EnGBtn = new TextBox();
            EdateBtn = new TextBox();
            CCBtn = new TextBox();
            StNBtn = new TextBox();
            EIDBtn = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            EditBtn = new Button();
            CreateBtn = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox6 = new TextBox();
            RoomBtn = new Button();
            SemesterBtn = new Button();
            ProfessorBtn = new Button();
            DepartmentBtn = new Button();
            BuildingBtn = new Button();
            StudentBtn = new Button();
            ClassBtn = new Button();
            SchoolBtn = new Button();
            CourseBtn = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // EnGBtn
            // 
            EnGBtn.BorderStyle = BorderStyle.None;
            EnGBtn.Location = new Point(84, 386);
            EnGBtn.Name = "EnGBtn";
            EnGBtn.Size = new Size(163, 16);
            EnGBtn.TabIndex = 33;
            EnGBtn.TextChanged += EnGBtn_TextChanged;
            // 
            // EdateBtn
            // 
            EdateBtn.BorderStyle = BorderStyle.None;
            EdateBtn.Location = new Point(84, 328);
            EdateBtn.Name = "EdateBtn";
            EdateBtn.Size = new Size(163, 16);
            EdateBtn.TabIndex = 32;
            EdateBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // CCBtn
            // 
            CCBtn.BorderStyle = BorderStyle.None;
            CCBtn.Location = new Point(84, 280);
            CCBtn.Name = "CCBtn";
            CCBtn.Size = new Size(163, 16);
            CCBtn.TabIndex = 31;
            CCBtn.TextChanged += CCBtn_TextChanged;
            // 
            // StNBtn
            // 
            StNBtn.BorderStyle = BorderStyle.None;
            StNBtn.Location = new Point(84, 222);
            StNBtn.Name = "StNBtn";
            StNBtn.Size = new Size(163, 16);
            StNBtn.TabIndex = 30;
            StNBtn.TextChanged += StNBtn_TextChanged;
            // 
            // EIDBtn
            // 
            EIDBtn.BorderStyle = BorderStyle.None;
            EIDBtn.Location = new Point(84, 174);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(163, 16);
            EIDBtn.TabIndex = 29;
            EIDBtn.TextChanged += EIDBtn_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox5.Location = new Point(72, 143);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 20);
            textBox5.TabIndex = 28;
            textBox5.Text = "Student Number:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox4.Location = new Point(84, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(55, 20);
            textBox4.TabIndex = 27;
            textBox4.Text = "Email:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox3.Location = new Point(84, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 20);
            textBox3.TabIndex = 26;
            textBox3.Text = "Department Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox2.Location = new Point(84, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 20);
            textBox2.TabIndex = 25;
            textBox2.Text = "Last Name:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(800, 511);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(98, 30);
            DeleteBtn.TabIndex = 23;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(618, 512);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(113, 30);
            UpdateBtn.TabIndex = 22;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(458, 510);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(95, 31);
            EditBtn.TabIndex = 21;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += ReadBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(288, 511);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(98, 31);
            CreateBtn.TabIndex = 20;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox1.Location = new Point(84, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 20);
            textBox1.TabIndex = 24;
            textBox1.Text = "First Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(288, 174);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(610, 317);
            dataGridViewBtn.TabIndex = 18;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(495, 115);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(226, 33);
            textBox6.TabIndex = 34;
            textBox6.Text = "Student Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            RoomBtn.Location = new Point(767, 57);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(102, 26);
            RoomBtn.TabIndex = 100;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SemesterBtn.Location = new Point(596, 22);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 101;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ProfessorBtn.Location = new Point(596, 71);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 102;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            DepartmentBtn.Location = new Point(409, 22);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 103;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BuildingBtn.Location = new Point(409, 71);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 104;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            StudentBtn.Location = new Point(246, 22);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 105;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ClassBtn.Location = new Point(84, 22);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 106;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            ClassBtn.Click += ClassBtn_Click;
            // 
            // SchoolBtn
            // 
            SchoolBtn.FlatStyle = FlatStyle.Popup;
            SchoolBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SchoolBtn.Location = new Point(84, 71);
            SchoolBtn.Name = "SchoolBtn";
            SchoolBtn.Size = new Size(102, 26);
            SchoolBtn.TabIndex = 107;
            SchoolBtn.Text = "SCHOOL";
            SchoolBtn.UseVisualStyleBackColor = true;
            SchoolBtn.Click += SchoolBtn_Click;
            // 
            // CourseBtn
            // 
            CourseBtn.FlatStyle = FlatStyle.Popup;
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            CourseBtn.Location = new Point(246, 71);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 108;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(288, 152);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Search here";
            textBox7.Size = new Size(610, 16);
            textBox7.TabIndex = 109;
            // 
            // StudentsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(textBox7);
            Controls.Add(CourseBtn);
            Controls.Add(SchoolBtn);
            Controls.Add(ClassBtn);
            Controls.Add(StudentBtn);
            Controls.Add(BuildingBtn);
            Controls.Add(DepartmentBtn);
            Controls.Add(ProfessorBtn);
            Controls.Add(SemesterBtn);
            Controls.Add(RoomBtn);
            Controls.Add(textBox6);
            Controls.Add(EnGBtn);
            Controls.Add(EdateBtn);
            Controls.Add(CCBtn);
            Controls.Add(StNBtn);
            Controls.Add(EIDBtn);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(EditBtn);
            Controls.Add(CreateBtn);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsInfo";
            Text = "Students";
            Load += StudentsInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EnGBtn;
        private TextBox EdateBtn;
        private TextBox CCBtn;
        private TextBox StNBtn;
        private TextBox EIDBtn;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button EditBtn;
        private Button CreateBtn;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox6;
        private Button RoomBtn;
        private Button SemesterBtn;
        private Button ProfessorBtn;
        private Button DepartmentBtn;
        private Button BuildingBtn;
        private Button StudentBtn;
        private Button ClassBtn;
        private Button SchoolBtn;
        private Button CourseBtn;
        private TextBox textBox7;
    }
}