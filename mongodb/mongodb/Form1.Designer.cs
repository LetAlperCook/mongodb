namespace mongodb
{
    partial class Form1
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
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(673, 105);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "Username";
            usernameTB.Size = new Size(100, 23);
            usernameTB.TabIndex = 0;
            usernameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(673, 189);
            passwordTB.Name = "passwordTB";
            passwordTB.PlaceholderText = "Password";
            passwordTB.Size = new Size(100, 23);
            passwordTB.TabIndex = 1;
            passwordTB.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(570, 151);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Hide password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(687, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 863);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private TextBox passwordTB;
        private CheckBox checkBox1;
        private Button button1;
    }
}