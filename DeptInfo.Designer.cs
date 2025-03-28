namespace tinycollege
{
    partial class DeptInfo
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
            ScBtn = new TextBox();
            deptnameBtn = new TextBox();
            DeptcodeBtn = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ReadBtn = new Button();
            CreateBtn = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(1008, 0);
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
            textBox6.Location = new Point(575, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 40);
            textBox6.TabIndex = 51;
            textBox6.Text = "Department Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(269, 512);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(100, 16);
            ProfnumBtn.TabIndex = 49;
            ProfnumBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // ScBtn
            // 
            ScBtn.BorderStyle = BorderStyle.None;
            ScBtn.Location = new Point(269, 403);
            ScBtn.Name = "ScBtn";
            ScBtn.Size = new Size(100, 16);
            ScBtn.TabIndex = 48;
            ScBtn.TextChanged += ScBtn_TextChanged;
            // 
            // deptnameBtn
            // 
            deptnameBtn.BorderStyle = BorderStyle.None;
            deptnameBtn.Location = new Point(269, 310);
            deptnameBtn.Name = "deptnameBtn";
            deptnameBtn.Size = new Size(100, 16);
            deptnameBtn.TabIndex = 47;
            deptnameBtn.TextChanged += deptnameBtn_TextChanged;
            // 
            // DeptcodeBtn
            // 
            DeptcodeBtn.BorderStyle = BorderStyle.None;
            DeptcodeBtn.Location = new Point(269, 212);
            DeptcodeBtn.Name = "DeptcodeBtn";
            DeptcodeBtn.Size = new Size(100, 16);
            DeptcodeBtn.TabIndex = 46;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(67, 511);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 19);
            textBox4.TabIndex = 44;
            textBox4.Text = "Prof Num:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(67, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 19);
            textBox3.TabIndex = 43;
            textBox3.Text = "Department Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(67, 403);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 19);
            textBox2.TabIndex = 42;
            textBox2.Text = "School Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(960, 626);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(95, 33);
            DeleteBtn.TabIndex = 40;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(783, 626);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(95, 35);
            UpdateBtn.TabIndex = 39;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(597, 626);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(95, 33);
            ReadBtn.TabIndex = 38;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(420, 626);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(95, 35);
            CreateBtn.TabIndex = 37;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 19);
            textBox1.TabIndex = 41;
            textBox1.Text = "Department Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(420, 192);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(635, 373);
            dataGridViewBtn.TabIndex = 35;
            // 
            // DeptInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1080, 694);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(ScBtn);
            Controls.Add(deptnameBtn);
            Controls.Add(DeptcodeBtn);
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
            Name = "DeptInfo";
            Text = "DeptInfo";
            Load += DeptInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox ProfnumBtn;
        private TextBox ScBtn;
        private TextBox deptnameBtn;
        private TextBox DeptcodeBtn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ReadBtn;
        private Button CreateBtn;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
    }
}