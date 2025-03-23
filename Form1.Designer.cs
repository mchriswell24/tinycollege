namespace tinycollege
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usnmetxt = new TextBox();
            textBox2 = new TextBox();
            UsernameBtn = new TextBox();
            PasswordBtn = new TextBox();
            LoginBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // usnmetxt
            // 
            usnmetxt.BackColor = Color.Tan;
            usnmetxt.BorderStyle = BorderStyle.None;
            usnmetxt.Location = new Point(387, 320);
            usnmetxt.Name = "usnmetxt";
            usnmetxt.Size = new Size(100, 19);
            usnmetxt.TabIndex = 0;
            usnmetxt.Text = "Username:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(387, 375);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 1;
            textBox2.Text = "Password:";
            // 
            // UsernameBtn
            // 
            UsernameBtn.Location = new Point(493, 317);
            UsernameBtn.Name = "UsernameBtn";
            UsernameBtn.Size = new Size(205, 26);
            UsernameBtn.TabIndex = 2;
            // 
            // PasswordBtn
            // 
            PasswordBtn.Location = new Point(493, 372);
            PasswordBtn.Name = "PasswordBtn";
            PasswordBtn.Size = new Size(205, 26);
            PasswordBtn.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Location = new Point(542, 404);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 30);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(400, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 66);
            textBox1.TabIndex = 5;
            textBox1.Text = "TINY COLLEGE";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1143, 600);
            Controls.Add(textBox1);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordBtn);
            Controls.Add(UsernameBtn);
            Controls.Add(textBox2);
            Controls.Add(usnmetxt);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usnmetxt;
        private TextBox textBox2;
        private TextBox UsernameBtn;
        private TextBox PasswordBtn;
        private Button LoginBtn;
        private TextBox textBox1;
    }
}
