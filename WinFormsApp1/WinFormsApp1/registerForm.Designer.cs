namespace Library
{
    partial class registerForm
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            countriesComboBox = new ComboBox();
            registerButton = new Button();
            label6 = new Label();
            label5 = new Label();
            lNameTextBox = new TextBox();
            fNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            registerLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(countriesComboBox);
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lNameTextBox);
            groupBox1.Controls.Add(fNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(registerLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Box";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 143);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "country";
            // 
            // countriesComboBox
            // 
            countriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countriesComboBox.FormattingEnabled = true;
            countriesComboBox.Location = new Point(245, 140);
            countriesComboBox.Name = "countriesComboBox";
            countriesComboBox.Size = new Size(100, 23);
            countriesComboBox.TabIndex = 12;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(6, 169);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(372, 23);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 114);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 85);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "first name";
            // 
            // lNameTextBox
            // 
            lNameTextBox.Location = new Point(245, 111);
            lNameTextBox.Name = "lNameTextBox";
            lNameTextBox.RightToLeft = RightToLeft.Yes;
            lNameTextBox.Size = new Size(100, 23);
            lNameTextBox.TabIndex = 8;
            // 
            // fNameTextBox
            // 
            fNameTextBox.Location = new Point(245, 82);
            fNameTextBox.Name = "fNameTextBox";
            fNameTextBox.RightToLeft = RightToLeft.Yes;
            fNameTextBox.Size = new Size(100, 23);
            fNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 143);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(71, 140);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.RightToLeft = RightToLeft.Yes;
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(71, 111);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.RightToLeft = RightToLeft.Yes;
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(71, 82);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.RightToLeft = RightToLeft.Yes;
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 1;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 33F);
            registerLabel.Location = new Point(103, 9);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(182, 60);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Register";
            registerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 223);
            Controls.Add(groupBox1);
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label registerLabel;
        private TextBox emailTextBox;
        private TextBox fNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button registerButton;
        private Label label6;
        private Label label5;
        private TextBox lNameTextBox;
        private Label label7;
        private ComboBox countriesComboBox;
    }
}