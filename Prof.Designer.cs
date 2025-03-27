namespace tinycollege
{
    partial class Prof
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
            dataGridViewBtn = new DataGridView();
            panel1 = new Panel();
            CrossBtn = new Button();
            CreateBtn = new Button();
            ReadBtn = new Button();
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
            EdateBtn = new TextBox();
            EnGBtn = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(399, 190);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(635, 373);
            dataGridViewBtn.TabIndex = 0;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(CrossBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 105);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(1102, 0);
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
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(399, 624);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(95, 35);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(576, 624);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(95, 33);
            ReadBtn.TabIndex = 5;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(762, 624);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(95, 35);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(939, 624);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(95, 33);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 19);
            textBox1.TabIndex = 8;
            textBox1.Text = "Enrollment ID:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(63, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 19);
            textBox2.TabIndex = 9;
            textBox2.Text = "Class Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(63, 540);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 19);
            textBox3.TabIndex = 10;
            textBox3.Text = "Enrollment Grade:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(63, 456);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 19);
            textBox4.TabIndex = 11;
            textBox4.Text = "Enrollment Date:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(51, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 19);
            textBox5.TabIndex = 12;
            textBox5.Text = "Student Number:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // EIDBtn
            // 
            EIDBtn.BorderStyle = BorderStyle.None;
            EIDBtn.Location = new Point(248, 190);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(100, 16);
            EIDBtn.TabIndex = 13;
            EIDBtn.TextChanged += EIDBtn_TextChanged;
            // 
            // StNBtn
            // 
            StNBtn.Location = new Point(248, 276);
            StNBtn.Name = "StNBtn";
            StNBtn.Size = new Size(100, 23);
            StNBtn.TabIndex = 14;
            StNBtn.TextChanged += StNBtn_TextChanged;
            // 
            // CCBtn
            // 
            CCBtn.Location = new Point(248, 363);
            CCBtn.Name = "CCBtn";
            CCBtn.Size = new Size(100, 23);
            CCBtn.TabIndex = 15;
            CCBtn.TextChanged += CCBtn_TextChanged;
            // 
            // EdateBtn
            // 
            EdateBtn.Location = new Point(248, 456);
            EdateBtn.Name = "EdateBtn";
            EdateBtn.Size = new Size(100, 23);
            EdateBtn.TabIndex = 16;
            EdateBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // EnGBtn
            // 
            EnGBtn.Location = new Point(248, 540);
            EnGBtn.Name = "EnGBtn";
            EnGBtn.Size = new Size(100, 23);
            EnGBtn.TabIndex = 17;
            EnGBtn.TextChanged += EnGBtn_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(576, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(219, 40);
            textBox6.TabIndex = 18;
            textBox6.Text = "Enrollment";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // Prof
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1177, 696);
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
            Controls.Add(textBox1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ReadBtn);
            Controls.Add(CreateBtn);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prof";
            Text = "Prof";
            Load += Prof_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBtn;
        private Panel panel1;
        private Button CrossBtn;
        private Button CreateBtn;
        private Button ReadBtn;
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
        private TextBox EdateBtn;
        private TextBox EnGBtn;
        private TextBox textBox6;
    }
}