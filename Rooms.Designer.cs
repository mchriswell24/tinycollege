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
            textBox6.Location = new Point(506, 136);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 33);
            textBox6.TabIndex = 79;
            textBox6.Text = "Rooms Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(229, 307);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(100, 16);
            BuildingcodeBtn.TabIndex = 78;
            BuildingcodeBtn.TextChanged += BuildingcodeBtn_TextChanged;
            // 
            // RoomtypeBtn
            // 
            RoomtypeBtn.BorderStyle = BorderStyle.None;
            RoomtypeBtn.Location = new Point(229, 269);
            RoomtypeBtn.Name = "RoomtypeBtn";
            RoomtypeBtn.Size = new Size(100, 16);
            RoomtypeBtn.TabIndex = 77;
            RoomtypeBtn.TextChanged += RoomtypeBtn_TextChanged;
            // 
            // RoomcodeBtn
            // 
            RoomcodeBtn.BorderStyle = BorderStyle.None;
            RoomcodeBtn.Location = new Point(229, 233);
            RoomcodeBtn.Name = "RoomcodeBtn";
            RoomcodeBtn.Size = new Size(100, 16);
            RoomcodeBtn.TabIndex = 76;
            RoomcodeBtn.TextChanged += RoomcodeBtn_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(57, 303);
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
            BtnDelete.Location = new Point(829, 474);
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
            BtnUpdate.Location = new Point(673, 474);
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
            BtnRead.Location = new Point(526, 474);
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
            BtnInsert.Location = new Point(380, 470);
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
            textBox1.Location = new Point(57, 265);
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
            dataGridViewBtn.Location = new Point(380, 197);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(544, 265);
            dataGridViewBtn.TabIndex = 67;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(57, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 19);
            textBox3.TabIndex = 80;
            textBox3.Text = "Room Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(380, 175);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(544, 16);
            textBox4.TabIndex = 81;
            // 
            // RoomsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(992, 571);
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
    }
}