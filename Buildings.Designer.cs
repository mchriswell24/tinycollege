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
            CrossBtn.Location = new Point(1102, 0);
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
            textBox6.Location = new Point(580, 161);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 40);
            textBox6.TabIndex = 66;
            textBox6.Text = "Building Info";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // buildinglocBtn
            // 
            buildinglocBtn.BorderStyle = BorderStyle.None;
            buildinglocBtn.Location = new Point(274, 497);
            buildinglocBtn.Name = "buildinglocBtn";
            buildinglocBtn.Size = new Size(100, 16);
            buildinglocBtn.TabIndex = 64;
            // 
            // BuildingnameBtn
            // 
            BuildingnameBtn.BorderStyle = BorderStyle.None;
            BuildingnameBtn.Location = new Point(274, 400);
            BuildingnameBtn.Name = "BuildingnameBtn";
            BuildingnameBtn.Size = new Size(100, 16);
            BuildingnameBtn.TabIndex = 63;
            // 
            // BuildingcodeBtn
            // 
            BuildingcodeBtn.BorderStyle = BorderStyle.None;
            BuildingcodeBtn.Location = new Point(274, 315);
            BuildingcodeBtn.Name = "BuildingcodeBtn";
            BuildingcodeBtn.Size = new Size(100, 16);
            BuildingcodeBtn.TabIndex = 62;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(72, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 19);
            textBox3.TabIndex = 60;
            textBox3.Text = "Building Code:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(72, 494);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 19);
            textBox2.TabIndex = 59;
            textBox2.Text = "Building Location:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(965, 623);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(95, 33);
            DeleteBtn.TabIndex = 57;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(799, 623);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(95, 35);
            UpdateBtn.TabIndex = 56;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.FlatStyle = FlatStyle.Popup;
            ReadBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadBtn.Location = new Point(600, 623);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(95, 33);
            ReadBtn.TabIndex = 55;
            ReadBtn.Text = "READ";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(425, 621);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(95, 35);
            CreateBtn.TabIndex = 54;
            CreateBtn.Text = "CREATE";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(72, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 19);
            textBox1.TabIndex = 58;
            textBox1.Text = "Building Name:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(CrossBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 105);
            panel1.TabIndex = 53;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(425, 223);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(635, 373);
            dataGridViewBtn.TabIndex = 52;
            // 
            // Buildings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1177, 712);
            Controls.Add(textBox6);
            Controls.Add(buildinglocBtn);
            Controls.Add(BuildingnameBtn);
            Controls.Add(BuildingcodeBtn);
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
            Name = "Buildings";
            Text = "Buildings";
            Load += Buildings_Load;
            panel1.ResumeLayout(false);
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
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ReadBtn;
        private Button CreateBtn;
        private TextBox textBox1;
        private Panel panel1;
        private DataGridView dataGridViewBtn;
    }
}