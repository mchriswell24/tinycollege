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
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnEdit = new Button();
            BtnCreate = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(919, 0);
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
            textBox6.Location = new Point(519, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 51;
            textBox6.Text = "Department Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // ProfnumBtn
            // 
            ProfnumBtn.BorderStyle = BorderStyle.None;
            ProfnumBtn.Location = new Point(67, 412);
            ProfnumBtn.Name = "ProfnumBtn";
            ProfnumBtn.Size = new Size(256, 16);
            ProfnumBtn.TabIndex = 49;
            ProfnumBtn.TextChanged += EdateBtn_TextChanged;
            // 
            // ScBtn
            // 
            ScBtn.BorderStyle = BorderStyle.None;
            ScBtn.Location = new Point(67, 352);
            ScBtn.Name = "ScBtn";
            ScBtn.Size = new Size(256, 16);
            ScBtn.TabIndex = 48;
            ScBtn.TextChanged += ScBtn_TextChanged;
            // 
            // deptnameBtn
            // 
            deptnameBtn.BorderStyle = BorderStyle.None;
            deptnameBtn.Location = new Point(67, 296);
            deptnameBtn.Name = "deptnameBtn";
            deptnameBtn.Size = new Size(256, 16);
            deptnameBtn.TabIndex = 47;
            deptnameBtn.TextChanged += deptnameBtn_TextChanged;
            // 
            // DeptcodeBtn
            // 
            DeptcodeBtn.BorderStyle = BorderStyle.None;
            DeptcodeBtn.Location = new Point(67, 234);
            DeptcodeBtn.Name = "DeptcodeBtn";
            DeptcodeBtn.Size = new Size(256, 16);
            DeptcodeBtn.TabIndex = 46;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Tan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(67, 387);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 20);
            textBox4.TabIndex = 44;
            textBox4.Text = "Prof Num:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(67, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 43;
            textBox3.Text = "Department Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(67, 327);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 20);
            textBox2.TabIndex = 42;
            textBox2.Text = "School Code:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(831, 513);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 28);
            BtnDelete.TabIndex = 40;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(691, 513);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 28);
            BtnUpdate.TabIndex = 39;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(553, 513);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 28);
            BtnEdit.TabIndex = 38;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            BtnCreate.FlatStyle = FlatStyle.Popup;
            BtnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(420, 513);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(95, 28);
            BtnCreate.TabIndex = 37;
            BtnCreate.Text = "CREATE";
            BtnCreate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 20);
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
            dataGridViewBtn.Size = new Size(506, 298);
            dataGridViewBtn.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(420, 170);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search here";
            textBox5.Size = new Size(506, 16);
            textBox5.TabIndex = 52;
            // 
            // DeptInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(textBox5);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(ProfnumBtn);
            Controls.Add(ScBtn);
            Controls.Add(deptnameBtn);
            Controls.Add(DeptcodeBtn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnCreate);
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
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnEdit;
        private Button BtnCreate;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox5;
    }
}