namespace tinycollege
{
    partial class CoursesInfo
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
            CreditsBtn = new TextBox();
            CoursedescBtn = new TextBox();
            CoursetitleBtn = new TextBox();
            deptcodeBtn = new TextBox();
            PNBtn = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ReadBtn = new Button();
            CreateBtn = new Button();
            textBox1 = new TextBox();
            CrossBtn = new Button();
            dataGridViewBtn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(526, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(287, 40);
            textBox6.TabIndex = 89;
            textBox6.Text = "Courses  Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // CreditsBtn
            // 
            CreditsBtn.BorderStyle = BorderStyle.None;
            CreditsBtn.Location = new Point(221, 606);
            CreditsBtn.Name = "CreditsBtn";
            CreditsBtn.Size = new Size(101, 16);
            CreditsBtn.TabIndex = 88;
            CreditsBtn.TextChanged += CreditsBtn_TextChanged;
            // 
            // CoursedescBtn
            // 
            CoursedescBtn.BorderStyle = BorderStyle.None;
            CoursedescBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoursedescBtn.Location = new Point(221, 511);
            CoursedescBtn.Name = "CoursedescBtn";
            CoursedescBtn.Size = new Size(101, 15);
            CoursedescBtn.TabIndex = 87;
            CoursedescBtn.TextChanged += CoursedescBtn_TextChanged;
            // 
            // CoursetitleBtn
            // 
            CoursetitleBtn.BorderStyle = BorderStyle.None;
            CoursetitleBtn.Location = new Point(221, 410);
            CoursetitleBtn.Name = "CoursetitleBtn";
            CoursetitleBtn.Size = new Size(101, 16);
            CoursetitleBtn.TabIndex = 86;
            CoursetitleBtn.TextChanged += CoursetitleBtn_TextChanged;
            // 
            // deptcodeBtn
            // 
            deptcodeBtn.BorderStyle = BorderStyle.None;
            deptcodeBtn.Location = new Point(221, 299);
            deptcodeBtn.Name = "deptcodeBtn";
            deptcodeBtn.Size = new Size(101, 16);
            deptcodeBtn.TabIndex = 85;
            deptcodeBtn.TextChanged += deptcodeBtn_TextChanged;
            // 
            // PNBtn
            // 
            PNBtn.BorderStyle = BorderStyle.None;
            PNBtn.Location = new Point(221, 198);
            PNBtn.Name = "PNBtn";
            PNBtn.Size = new Size(101, 16);
            PNBtn.TabIndex = 84;
            PNBtn.TextChanged += PNBtn_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(24, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 19);
            textBox5.TabIndex = 83;
            textBox5.Text = "Course Code:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(24, 508);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 19);
            textBox4.TabIndex = 82;
            textBox4.Text = "Course Description:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 602);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 19);
            textBox3.TabIndex = 81;
            textBox3.Text = "Credits:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(36, 406);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 19);
            textBox2.TabIndex = 80;
            textBox2.Text = "Course Title:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(915, 643);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 52);
            DeleteBtn.TabIndex = 78;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(734, 643);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 52);
            UpdateBtn.TabIndex = 77;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(548, 643);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(101, 52);
            ReadBtn.TabIndex = 76;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(374, 643);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(101, 52);
            CreateBtn.TabIndex = 75;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(36, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 19);
            textBox1.TabIndex = 79;
            textBox1.Text = "Depatment Code:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(960, 2);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(101, 40);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(374, 185);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(642, 437);
            dataGridViewBtn.TabIndex = 73;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // CoursesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1058, 717);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(CreditsBtn);
            Controls.Add(CoursedescBtn);
            Controls.Add(CoursetitleBtn);
            Controls.Add(deptcodeBtn);
            Controls.Add(PNBtn);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ReadBtn);
            Controls.Add(CreateBtn);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesInfo";
            Text = "CoursesInfo";
            Load += CoursesInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private TextBox CreditsBtn;
        private TextBox CoursedescBtn;
        private TextBox CoursetitleBtn;
        private TextBox deptcodeBtn;
        private TextBox PNBtn;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ReadBtn;
        private Button CreateBtn;
        private TextBox textBox1;
        private Button CrossBtn;
        private DataGridView dataGridViewBtn;
    }
}