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
            BtnEdit = new Button();
            BtnCreate = new Button();
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
            BtnEnrollment = new Button();
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
            textBox6.Location = new Point(467, 146);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 79;
            textBox6.Text = "Rooms Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(84, 387);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(226, 16);
            BuildingcodeBtn.TabIndex = 78;
            BuildingcodeBtn.TextChanged += BuildingcodeBtn_TextChanged;
            // 
            // RoomtypeBtn
            // 
            RoomtypeBtn.BorderStyle = BorderStyle.None;
            RoomtypeBtn.Location = new Point(84, 327);
            RoomtypeBtn.Name = "RoomtypeBtn";
            RoomtypeBtn.Size = new Size(226, 16);
            RoomtypeBtn.TabIndex = 77;
            RoomtypeBtn.TextChanged += RoomtypeBtn_TextChanged;
            // 
            // RoomcodeBtn
            // 
            RoomcodeBtn.BorderStyle = BorderStyle.None;
            RoomcodeBtn.Location = new Point(84, 268);
            RoomcodeBtn.Name = "RoomcodeBtn";
            RoomcodeBtn.Size = new Size(226, 16);
            RoomcodeBtn.TabIndex = 76;
            RoomcodeBtn.TextChanged += RoomcodeBtn_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(67, 362);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 17);
            textBox2.TabIndex = 74;
            textBox2.Text = "Building Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(800, 488);
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
            BtnUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(650, 488);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 29);
            BtnUpdate.TabIndex = 71;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(505, 488);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 29);
            BtnEdit.TabIndex = 70;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += ReadBtn_Click;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(351, 488);
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
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 17);
            textBox1.TabIndex = 73;
            textBox1.Text = "Room Type:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(351, 207);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(544, 265);
            dataGridViewBtn.TabIndex = 67;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(67, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 17);
            textBox3.TabIndex = 80;
            textBox3.Text = "Room Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(351, 185);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(544, 16);
            textBox4.TabIndex = 81;
            // 
            // ClassBtn
            // 
            ClassBtn.FlatStyle = FlatStyle.Popup;
            ClassBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassBtn.Location = new Point(67, 42);
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
            SchoolBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchoolBtn.Location = new Point(67, 90);
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
            CourseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseBtn.Location = new Point(223, 42);
            CourseBtn.Name = "CourseBtn";
            CourseBtn.Size = new Size(102, 26);
            CourseBtn.TabIndex = 108;
            CourseBtn.Text = "COURSE";
            CourseBtn.UseVisualStyleBackColor = true;
            CourseBtn.Click += CourseBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.FlatStyle = FlatStyle.Popup;
            StudentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentBtn.Location = new Point(223, 90);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(102, 26);
            StudentBtn.TabIndex = 109;
            StudentBtn.Text = "STUDENT";
            StudentBtn.UseVisualStyleBackColor = true;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.FlatStyle = FlatStyle.Popup;
            DepartmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentBtn.Location = new Point(400, 42);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(144, 26);
            DepartmentBtn.TabIndex = 110;
            DepartmentBtn.Text = "DEPARTMENT";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // BuildingBtn
            // 
            BuildingBtn.FlatStyle = FlatStyle.Popup;
            BuildingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuildingBtn.Location = new Point(400, 90);
            BuildingBtn.Name = "BuildingBtn";
            BuildingBtn.Size = new Size(144, 26);
            BuildingBtn.TabIndex = 111;
            BuildingBtn.Text = "BUILDING";
            BuildingBtn.UseVisualStyleBackColor = true;
            BuildingBtn.Click += BuildingBtn_Click;
            // 
            // SemesterBtn
            // 
            SemesterBtn.FlatStyle = FlatStyle.Popup;
            SemesterBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SemesterBtn.Location = new Point(601, 42);
            SemesterBtn.Name = "SemesterBtn";
            SemesterBtn.Size = new Size(144, 26);
            SemesterBtn.TabIndex = 112;
            SemesterBtn.Text = "SEMESTER";
            SemesterBtn.UseVisualStyleBackColor = true;
            SemesterBtn.Click += SemesterBtn_Click;
            // 
            // ProfessorBtn
            // 
            ProfessorBtn.FlatStyle = FlatStyle.Popup;
            ProfessorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfessorBtn.Location = new Point(601, 90);
            ProfessorBtn.Name = "ProfessorBtn";
            ProfessorBtn.Size = new Size(144, 26);
            ProfessorBtn.TabIndex = 113;
            ProfessorBtn.Text = "PROFESSOR";
            ProfessorBtn.UseVisualStyleBackColor = true;
            ProfessorBtn.Click += ProfessorBtn_Click;
            // 
            // RoomBtn
            // 
            RoomBtn.FlatStyle = FlatStyle.Popup;
            RoomBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomBtn.Location = new Point(793, 42);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(131, 26);
            RoomBtn.TabIndex = 114;
            RoomBtn.Text = "ROOM";
            RoomBtn.UseVisualStyleBackColor = true;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // BtnEnrollment
            // 
            BtnEnrollment.FlatStyle = FlatStyle.Popup;
            BtnEnrollment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BtnEnrollment.Location = new Point(793, 90);
            BtnEnrollment.Name = "BtnEnrollment";
            BtnEnrollment.Size = new Size(131, 26);
            BtnEnrollment.TabIndex = 127;
            BtnEnrollment.Text = "ENROLLMENT";
            BtnEnrollment.UseVisualStyleBackColor = true;
            BtnEnrollment.Click += BtnEnrollment_Click;
            // 
            // RoomsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(BtnEnrollment);
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
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
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
        private Button BtnEdit;
        private Button BtnCreate;
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
        private Button BtnEnrollment;
    }
}