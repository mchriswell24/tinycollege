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
            ReadBtn = new Button();
            CreateBtn = new Button();
            CrossBtn = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            dataGridViewBtn = new DataGridView();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // EnGBtn
            // 
            EnGBtn.Location = new Point(193, 478);
            EnGBtn.Name = "EnGBtn";
            EnGBtn.Size = new Size(98, 23);
            EnGBtn.TabIndex = 33;
            EnGBtn.TextChanged += EnGBtn_TextChanged;
            // 
            // EdateBtn
            // 
            EdateBtn.Location = new Point(193, 385);
            EdateBtn.Name = "EdateBtn";
            EdateBtn.Size = new Size(98, 23);
            EdateBtn.TabIndex = 32;
            EdateBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // CCBtn
            // 
            CCBtn.Location = new Point(193, 299);
            CCBtn.Name = "CCBtn";
            CCBtn.Size = new Size(98, 23);
            CCBtn.TabIndex = 31;
            CCBtn.TextChanged += CCBtn_TextChanged;
            // 
            // StNBtn
            // 
            StNBtn.Location = new Point(193, 223);
            StNBtn.Name = "StNBtn";
            StNBtn.Size = new Size(98, 23);
            StNBtn.TabIndex = 30;
            StNBtn.TextChanged += StNBtn_TextChanged;
            // 
            // EIDBtn
            // 
            EIDBtn.BorderStyle = BorderStyle.None;
            EIDBtn.Location = new Point(193, 156);
            EIDBtn.Name = "EIDBtn";
            EIDBtn.Size = new Size(98, 16);
            EIDBtn.TabIndex = 29;
            EIDBtn.TextChanged += EIDBtn_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(23, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 19);
            textBox5.TabIndex = 28;
            textBox5.Text = "Student Number:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(23, 389);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(104, 19);
            textBox4.TabIndex = 27;
            textBox4.Text = "Email:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 477);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 19);
            textBox3.TabIndex = 26;
            textBox3.Text = "Department Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(23, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 19);
            textBox2.TabIndex = 25;
            textBox2.Text = "Last Name:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(846, 565);
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
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(663, 565);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(113, 30);
            UpdateBtn.TabIndex = 22;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(491, 565);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(95, 31);
            ReadBtn.TabIndex = 21;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(332, 564);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(98, 31);
            CreateBtn.TabIndex = 20;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(921, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(110, 31);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(23, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 19);
            textBox1.TabIndex = 24;
            textBox1.Text = "First Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(CrossBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 91);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(332, 179);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(612, 361);
            dataGridViewBtn.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(509, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(226, 40);
            textBox6.TabIndex = 34;
            textBox6.Text = "Student Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1029, 630);
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
            Controls.Add(ReadBtn);
            Controls.Add(CreateBtn);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsInfo";
            Text = "Students";
            Load += StudentsInfo_Load;
            panel1.ResumeLayout(false);
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
        private Button ReadBtn;
        private Button CreateBtn;
        private Button CrossBtn;
        private TextBox textBox1;
        private Panel panel1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox6;
    }
}