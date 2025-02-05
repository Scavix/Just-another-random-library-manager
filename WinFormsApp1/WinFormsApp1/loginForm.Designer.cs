namespace Library
{
    partial class loginForm
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
            loginButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            changeForgotPasswordLabel = new LinkLabel();
            registerLinkLabel = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(6, 142);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(180, 23);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(86, 84);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(86, 113);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(changeForgotPasswordLabel);
            groupBox1.Controls.Add(registerLinkLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 196);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Box";
            // 
            // changeForgotPasswordLabel
            // 
            changeForgotPasswordLabel.AutoSize = true;
            changeForgotPasswordLabel.Font = new Font("Segoe UI", 7F);
            changeForgotPasswordLabel.Location = new Point(70, 178);
            changeForgotPasswordLabel.Name = "changeForgotPasswordLabel";
            changeForgotPasswordLabel.Size = new Size(116, 12);
            changeForgotPasswordLabel.TabIndex = 7;
            changeForgotPasswordLabel.TabStop = true;
            changeForgotPasswordLabel.Text = "Change/Forgot Password";
            changeForgotPasswordLabel.LinkClicked += changeForgotPasswordlinkLabel_LinkClicked;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Font = new Font("Segoe UI", 7F);
            registerLinkLabel.Location = new Point(6, 178);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(39, 12);
            registerLinkLabel.TabIndex = 6;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 87);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 62);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 220);
            Controls.Add(groupBox1);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibraryMS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private LinkLabel registerLinkLabel;
        private LinkLabel changeForgotPasswordLabel;
    }
}
