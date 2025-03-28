namespace tinycollege
{
    partial class Buildings
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
            buildinglocBtn = new TextBox();
            BuildingnameBtn = new TextBox();
            BuildingcodeBtn = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnRead = new Button();
            BtnInsert = new Button();
            textBox1 = new TextBox();
            dataGridViewBtn = new DataGridView();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            SuspendLayout();
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrossBtn.Location = new Point(917, 0);
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
            textBox6.Location = new Point(514, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 66;
            textBox6.Text = "Building Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // buildinglocBtn
            // 
            buildinglocBtn.BorderStyle = BorderStyle.None;
            buildinglocBtn.Location = new Point(89, 347);
            buildinglocBtn.Name = "buildinglocBtn";
            buildinglocBtn.Size = new Size(253, 16);
            buildinglocBtn.TabIndex = 64;
            // 
            // BuildingnameBtn
            // 
            BuildingnameBtn.BorderStyle = BorderStyle.None;
            BuildingnameBtn.Location = new Point(89, 300);
            BuildingnameBtn.Name = "BuildingnameBtn";
            BuildingnameBtn.Size = new Size(253, 16);
            BuildingnameBtn.TabIndex = 63;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(89, 248);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(253, 16);
            BuildingcodeBtn.TabIndex = 62;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(69, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 20);
            textBox3.TabIndex = 60;
            textBox3.Text = "Building Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(89, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 20);
            textBox2.TabIndex = 59;
            textBox2.Text = "Building Location:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(836, 506);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 33);
            BtnDelete.TabIndex = 57;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += DeleteBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.FlatStyle = FlatStyle.Popup;
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(693, 504);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(95, 33);
            BtnUpdate.TabIndex = 56;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += UpdateBtn_Click;
            // 
            // BtnRead
            // 
            BtnRead.FlatStyle = FlatStyle.Popup;
            BtnRead.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnRead.Location = new Point(547, 504);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(95, 33);
            BtnRead.TabIndex = 55;
            BtnRead.Text = "READ";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += ReadBtn_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.FlatStyle = FlatStyle.Popup;
            BtnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnInsert.Location = new Point(398, 502);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(95, 33);
            BtnInsert.TabIndex = 54;
            BtnInsert.Text = "INSERT";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(69, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 20);
            textBox1.TabIndex = 58;
            textBox1.Text = "Building Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(398, 187);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(533, 295);
            dataGridViewBtn.TabIndex = 52;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(398, 165);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(533, 16);
            textBox4.TabIndex = 67;
            // 
            // Buildings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
            Controls.Add(textBox4);
            Controls.Add(CrossBtn);
            Controls.Add(textBox6);
            Controls.Add(buildinglocBtn);
            Controls.Add(BuildingnameBtn);
            Controls.Add(BuildingcodeBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnRead);
            Controls.Add(BtnInsert);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Buildings";
            Text = "Buildings";
            Load += Buildings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrossBtn;
        private TextBox textBox6;
        private TextBox buildinglocBtn;
        private TextBox BuildingnameBtn;
        private TextBox BuildingcodeBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnRead;
        private Button BtnInsert;
        private TextBox textBox1;
        private DataGridView dataGridViewBtn;
        private TextBox textBox4;
    }
}