namespace tinycollege
{
    partial class logins
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            UsernameBtn = new TextBox();
            PasswordBtn = new TextBox();
            textBox3 = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(269, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 19);
            textBox1.TabIndex = 0;
            textBox1.Text = "Username:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(269, 360);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 1;
            textBox2.Text = "Password:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // UsernameBtn
            // 
            UsernameBtn.BorderStyle = BorderStyle.None;
            UsernameBtn.Location = new Point(388, 322);
            UsernameBtn.Name = "UsernameBtn";
            UsernameBtn.Size = new Size(142, 16);
            UsernameBtn.TabIndex = 2;
            UsernameBtn.TextAlign = HorizontalAlignment.Center;
            UsernameBtn.TextChanged += UsernameBtn_TextChanged;
            // 
            // PasswordBtn
            // 
            PasswordBtn.BorderStyle = BorderStyle.None;
            PasswordBtn.Location = new Point(388, 360);
            PasswordBtn.Name = "PasswordBtn";
            PasswordBtn.Size = new Size(142, 16);
            PasswordBtn.TabIndex = 3;
            PasswordBtn.TextAlign = HorizontalAlignment.Center;
            PasswordBtn.TextChanged += PasswordBtn_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe Script", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(269, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 57);
            textBox3.TabIndex = 4;
            textBox3.Text = "TINY COLLEGE";
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(414, 391);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(81, 33);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // logins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(876, 597);
            Controls.Add(LoginBtn);
            Controls.Add(textBox3);
            Controls.Add(PasswordBtn);
            Controls.Add(UsernameBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logins";
            Text = "logins";
            Load += logins_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox UsernameBtn;
        private TextBox PasswordBtn;
        private TextBox textBox3;
        private Button LoginBtn;
    }
}