namespace tinycollege
{
    partial class Schools
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
            SchoolnameBtn = new TextBox();
            SchoolcodeBtn = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ReadBtn = new Button();
            CreateBtn = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            dataGridViewBtn = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(929, 0);
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
            textBox6.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(477, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 40);
            textBox6.TabIndex = 79;
            textBox6.Text = "School Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(183, 436);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(100, 16);
            ProfnumBtn.TabIndex = 78;
            ProfnumBtn.TextChanged += ProfnumBtn_TextChanged;
            // 
            // SchoolnameBtn
            // 
            SchoolnameBtn.BorderStyle = BorderStyle.None;
            SchoolnameBtn.Location = new Point(183, 361);
            SchoolnameBtn.Name = "SchoolnameBtn";
            SchoolnameBtn.Size = new Size(100, 16);
            SchoolnameBtn.TabIndex = 77;
            SchoolnameBtn.TextChanged += SchoolnameBtn_TextChanged;
            // 
            // SchoolcodeBtn
            // 
            SchoolcodeBtn.BorderStyle = BorderStyle.None;
            SchoolcodeBtn.Location = new Point(183, 276);
            SchoolcodeBtn.Name = "SchoolcodeBtn";
            SchoolcodeBtn.Size = new Size(100, 16);
            SchoolcodeBtn.TabIndex = 76;
            SchoolcodeBtn.TextChanged += SchoolcodeBtn_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 19);
            textBox3.TabIndex = 75;
            textBox3.Text = "School Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 436);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 19);
            textBox2.TabIndex = 74;
            textBox2.Text = "Prof Num:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(874, 584);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(95, 33);
            DeleteBtn.TabIndex = 72;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(680, 582);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(95, 35);
            UpdateBtn.TabIndex = 71;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(509, 584);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(95, 33);
            ReadBtn.TabIndex = 70;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(334, 582);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(95, 35);
            CreateBtn.TabIndex = 69;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 19);
            textBox1.TabIndex = 73;
            textBox1.Text = "School  Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(CrossBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 105);
            panel1.TabIndex = 68;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(334, 184);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(635, 373);
            dataGridViewBtn.TabIndex = 67;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // Schools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1004, 670);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(SchoolnameBtn);
            Controls.Add(SchoolcodeBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ReadBtn);
            Controls.Add(CreateBtn);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schools";
            Text = "Schools";
            Load += Schools_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox ProfnumBtn;
        private TextBox SchoolnameBtn;
        private TextBox SchoolcodeBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ReadBtn;
        private Button CreateBtn;
        private TextBox textBox1;
        private Panel panel1;
        private DataGridView dataGridViewBtn;
    }
}