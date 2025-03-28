namespace tinycollege
{
    partial class SchoolInfo
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
            ProfnumBtn = new TextBox();
            SchoolnameBtn = new TextBox();
            SchoolcodeBtn = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnEdit = new Button();
            BtnCreate = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            CrossBtn = new Button();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Tan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(516, 127);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 79;
            textBox6.Text = "School Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(92, 368);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(241, 16);
            ProfnumBtn.TabIndex = 78;
            ProfnumBtn.TextChanged += ProfnumBtn_TextChanged;
            // 
            // SchoolnameBtn
            // 
            SchoolnameBtn.BorderStyle = BorderStyle.None;
            SchoolnameBtn.Location = new Point(92, 305);
            SchoolnameBtn.Name = "SchoolnameBtn";
            SchoolnameBtn.Size = new Size(241, 16);
            SchoolnameBtn.TabIndex = 77;
            SchoolnameBtn.TextChanged += SchoolnameBtn_TextChanged;
            // 
            // SchoolcodeBtn
            // 
            SchoolcodeBtn.BorderStyle = BorderStyle.None;
            SchoolcodeBtn.Location = new Point(92, 243);
            SchoolcodeBtn.Name = "SchoolcodeBtn";
            SchoolcodeBtn.Size = new Size(241, 16);
            SchoolcodeBtn.TabIndex = 76;
            SchoolcodeBtn.TextChanged += SchoolcodeBtn_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(78, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 75;
            textBox3.Text = "School Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(56, 343);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 20);
            textBox2.TabIndex = 74;
            textBox2.Text = "Prof Num:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(841, 495);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 33);
            BtnDelete.TabIndex = 72;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += DeleteBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(689, 495);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 33);
            BtnUpdate.TabIndex = 71;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(539, 495);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 33);
            BtnEdit.TabIndex = 70;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += ReadBtn_Click;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(388, 495);
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
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 20);
            textBox1.TabIndex = 73;
            textBox1.Text = "School  Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(388, 195);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(548, 290);
            dataGridViewBtn.TabIndex = 67;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(918, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(75, 23);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(388, 173);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(548, 16);
            textBox4.TabIndex = 80;
            // 
            // SchoolInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(textBox4);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(SchoolnameBtn);
            Controls.Add(SchoolcodeBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SchoolInfo";
            Text = "Schools";
            Load += Schools_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private TextBox ProfnumBtn;
        private TextBox SchoolnameBtn;
        private TextBox SchoolcodeBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnEdit;
        private Button BtnCreate;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private Button CrossBtn;
        private TextBox textBox4;
    }
}