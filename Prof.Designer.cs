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
            UpdatecomboBoxBtn = new ComboBox();
            panel1 = new Panel();
            CreatecomboBoxBtn = new ComboBox();
            ReadcomboBoxBtn = new ComboBox();
            DeletecomboBoxBtn = new ComboBox();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.BackgroundColor = Color.AntiqueWhite;
            dataGridViewBtn.BorderStyle = BorderStyle.None;
            dataGridViewBtn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBtn.Location = new Point(231, 182);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(677, 431);
            dataGridViewBtn.TabIndex = 0;
            dataGridViewBtn.CellContentClick += dataGridViewBtn_CellContentClick;
            // 
            // UpdatecomboBoxBtn
            // 
            UpdatecomboBoxBtn.FlatStyle = FlatStyle.Popup;
            UpdatecomboBoxBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UpdatecomboBoxBtn.FormattingEnabled = true;
            UpdatecomboBoxBtn.Location = new Point(414, 47);
            UpdatecomboBoxBtn.Name = "UpdatecomboBoxBtn";
            UpdatecomboBoxBtn.Size = new Size(121, 28);
            UpdatecomboBoxBtn.TabIndex = 1;
            UpdatecomboBoxBtn.Text = "    UPDATE";
            UpdatecomboBoxBtn.SelectedIndexChanged += UpdatecomboBoxBtn_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(CrossBtn);
            panel1.Controls.Add(CreatecomboBoxBtn);
            panel1.Controls.Add(ReadcomboBoxBtn);
            panel1.Controls.Add(DeletecomboBoxBtn);
            panel1.Controls.Add(UpdatecomboBoxBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 105);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // CreatecomboBoxBtn
            // 
            CreatecomboBoxBtn.FlatStyle = FlatStyle.Popup;
            CreatecomboBoxBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreatecomboBoxBtn.FormattingEnabled = true;
            CreatecomboBoxBtn.Location = new Point(198, 47);
            CreatecomboBoxBtn.Name = "CreatecomboBoxBtn";
            CreatecomboBoxBtn.Size = new Size(121, 28);
            CreatecomboBoxBtn.TabIndex = 6;
            CreatecomboBoxBtn.Text = "    CREATE";
            CreatecomboBoxBtn.SelectedIndexChanged += CreatecomboBoxBtn_SelectedIndexChanged;
            // 
            // ReadcomboBoxBtn
            // 
            ReadcomboBoxBtn.FlatStyle = FlatStyle.Popup;
            ReadcomboBoxBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReadcomboBoxBtn.FormattingEnabled = true;
            ReadcomboBoxBtn.Location = new Point(630, 50);
            ReadcomboBoxBtn.Name = "ReadcomboBoxBtn";
            ReadcomboBoxBtn.Size = new Size(121, 28);
            ReadcomboBoxBtn.TabIndex = 5;
            ReadcomboBoxBtn.Text = "     READ";
            ReadcomboBoxBtn.SelectedIndexChanged += ReadcomboBoxBtn_SelectedIndexChanged;
            // 
            // DeletecomboBoxBtn
            // 
            DeletecomboBoxBtn.BackColor = SystemColors.ControlLightLight;
            DeletecomboBoxBtn.FlatStyle = FlatStyle.Popup;
            DeletecomboBoxBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeletecomboBoxBtn.FormattingEnabled = true;
            DeletecomboBoxBtn.Location = new Point(834, 52);
            DeletecomboBoxBtn.Name = "DeletecomboBoxBtn";
            DeletecomboBoxBtn.Size = new Size(121, 28);
            DeletecomboBoxBtn.TabIndex = 4;
            DeletecomboBoxBtn.Text = "    DELETE";
            DeletecomboBoxBtn.SelectedIndexChanged += DeletecomboBoxBtn_SelectedIndexChanged;
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
            // Prof
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1177, 696);
            Controls.Add(panel1);
            Controls.Add(dataGridViewBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prof";
            Text = "Prof";
            Load += Prof_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBtn).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBtn;
        private ComboBox UpdatecomboBoxBtn;
        private Panel panel1;
        private ComboBox DeletecomboBoxBtn;
        private ComboBox ReadcomboBoxBtn;
        private ComboBox CreatecomboBoxBtn;
        private Button CrossBtn;
    }
}