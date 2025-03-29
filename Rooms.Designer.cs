namespace tinycollege
{
    partial class RoomsInfo
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
            BuildingcodeBtn = new TextBox();
            RoomtypeBtn = new TextBox();
            RoomcodeBtn = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnRead = new Button();
            BtnInsert = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ClassBtn = new Button();
            SchoolBtn = new Button();
            CourseBtn = new Button();
            StudentBtn = new Button();
            DepartmentBtn = new Button();
            BuildingBtn = new Button();
            SemesterBtn = new Button();
            ProfessorBtn = new Button();
            RoomBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(918, -1);
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
            textBox6.Location = new Point(351, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 79;
            textBox6.Text = "Rooms Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(67, 409);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(155, 16);
            BuildingcodeBtn.TabIndex = 78;
            BuildingcodeBtn.TextChanged += BuildingcodeBtn_TextChanged;
            // 
            // RoomtypeBtn
            // 
            RoomtypeBtn.BorderStyle = BorderStyle.None;
            RoomtypeBtn.Location = new Point(67, 347);
            RoomtypeBtn.Name = "RoomtypeBtn";
            RoomtypeBtn.Size = new Size(155, 16);
            RoomtypeBtn.TabIndex = 77;
            RoomtypeBtn.TextChanged += RoomtypeBtn_TextChanged;
            // 
            // RoomcodeBtn
            // 
            RoomcodeBtn.BorderStyle = BorderStyle.None;
            RoomcodeBtn.Location = new Point(67, 268);
            RoomcodeBtn.Name = "RoomcodeBtn";
            RoomcodeBtn.Size = new Size(155, 16);
            RoomcodeBtn.TabIndex = 76;
            RoomcodeBtn.TextChanged += RoomcodeBtn_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(67, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 19);
            textBox2.TabIndex = 74;
            textBox2.Text = "Building Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(710, 501);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 29);
            BtnDelete.TabIndex = 72;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += DeleteBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(549, 501);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 29);
            BtnUpdate.TabIndex = 71;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnRead
            // 
            BtnRead.FlatStyle = FlatStyle.Popup;
            BtnRead.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnRead.Location = new Point(400, 501);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(95, 29);
            BtnRead.TabIndex = 70;
            BtnRead.Text = "READ";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += ReadBtn_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.FlatStyle = FlatStyle.Popup;
            BtnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnInsert.Location = new Point(261, 497);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(95, 33);
            BtnInsert.TabIndex = 69;
            BtnInsert.Text = "INSERT";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 19);
            textBox1.TabIndex = 73;
            textBox1.Text = "Room Type:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(261, 222);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(544, 265);
            dataGridViewBtn.TabIndex = 67;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(67, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 19);
            textBox3.TabIndex = 80;
            textBox3.Text = "Room Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(261, 200);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(544, 16);
            textBox4.TabIndex = 81;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ClassBtn.Location = new Point(67, 34);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(102, 26);
            ClassBtn.TabIndex = 106;
            ClassBtn.Text = "CLASS";
            ClassBtn.UseVisualStyleBackColor = true;
            // 
            // SchoolBtn
            // 
            SchoolBtn.FlatStyle = FlatStyle.Popup;
            SchoolBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SchoolBtn.Location = new Point(67, 82);
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
            CourseBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CourseBtn.Location = new Point(223, 34);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 108;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StudentBtn.Location = new Point(223, 82);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 109;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DepartmentBtn.Location = new Point(400, 34);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 110;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildingBtn.Location = new Point(400, 82);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 111;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SemesterBtn.Location = new Point(601, 34);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 112;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProfessorBtn.Location = new Point(601, 82);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 113;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RoomBtn.Location = new Point(784, 57);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(102, 26);
            RoomBtn.TabIndex = 114;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            // 
            // RoomsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(RoomBtn);
            Controls.Add(ProfessorBtn);
            Controls.Add(SemesterBtn);
            Controls.Add(BuildingBtn);
            Controls.Add(DepartmentBtn);
            Controls.Add(StudentBtn);
            Controls.Add(CourseBtn);
            Controls.Add(SchoolBtn);
            Controls.Add(ClassBtn);
            Controls.Add(textBox4);
            Controls.Add(CrossBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(BuildingcodeBtn);
            Controls.Add(RoomtypeBtn);
            Controls.Add(RoomcodeBtn);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnRead);
            Controls.Add(BtnInsert);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomsInfo";
            Text = "Rooms";
            Load += RoomsInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox BuildingcodeBtn;
        private TextBox RoomtypeBtn;
        private TextBox RoomcodeBtn;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnRead;
        private Button BtnInsert;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button ClassBtn;
        private Button SchoolBtn;
        private Button CourseBtn;
        private Button StudentBtn;
        private Button DepartmentBtn;
        private Button BuildingBtn;
        private Button SemesterBtn;
        private Button ProfessorBtn;
        private Button RoomBtn;
    }
}