namespace Library
{
    partial class changeForgotPasswordForm
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
            confirmButton = new Button();
            label4 = new Label();
            oldPassOrCodeLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            newPassTextBox = new TextBox();
            oldPassOrCodeTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            changeRadioButton = new RadioButton();
            forgotRadioButton = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(confirmButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(oldPassOrCodeLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(newPassTextBox);
            groupBox1.Controls.Add(oldPassOrCodeTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(changeRadioButton);
            groupBox1.Controls.Add(forgotRadioButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forgot Password";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(6, 163);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(184, 23);
            confirmButton.TabIndex = 10;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 137);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(82, 15);
            label4.TabIndex = 9;
            label4.Text = "new password";
            // 
            // oldPassOrCodeLabel
            // 
            oldPassOrCodeLabel.Location = new Point(6, 108);
            oldPassOrCodeLabel.Name = "oldPassOrCodeLabel";
            oldPassOrCodeLabel.RightToLeft = RightToLeft.Yes;
            oldPassOrCodeLabel.Size = new Size(77, 15);
            oldPassOrCodeLabel.TabIndex = 8;
            oldPassOrCodeLabel.Text = "old password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 79);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "username";
            // 
            // newPassTextBox
            // 
            newPassTextBox.Location = new Point(86, 134);
            newPassTextBox.Name = "newPassTextBox";
            newPassTextBox.Size = new Size(100, 23);
            newPassTextBox.TabIndex = 5;
            // 
            // oldPassOrCodeTextBox
            // 
            oldPassOrCodeTextBox.Location = new Point(86, 105);
            oldPassOrCodeTextBox.Name = "oldPassOrCodeTextBox";
            oldPassOrCodeTextBox.Size = new Size(100, 23);
            oldPassOrCodeTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(86, 76);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(86, 47);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // changeRadioButton
            // 
            changeRadioButton.AutoSize = true;
            changeRadioButton.Location = new Point(6, 22);
            changeRadioButton.Name = "changeRadioButton";
            changeRadioButton.Size = new Size(92, 19);
            changeRadioButton.TabIndex = 1;
            changeRadioButton.TabStop = true;
            changeRadioButton.Text = "Change pass";
            changeRadioButton.UseVisualStyleBackColor = true;
            changeRadioButton.CheckedChanged += changeRadioButton_CheckedChanged;
            // 
            // forgotRadioButton
            // 
            forgotRadioButton.AutoSize = true;
            forgotRadioButton.Location = new Point(104, 22);
            forgotRadioButton.Name = "forgotRadioButton";
            forgotRadioButton.Size = new Size(86, 19);
            forgotRadioButton.TabIndex = 0;
            forgotRadioButton.TabStop = true;
            forgotRadioButton.Text = "Forgot pass";
            forgotRadioButton.UseVisualStyleBackColor = true;
            forgotRadioButton.CheckedChanged += forgotRadioButton_CheckedChanged;
            // 
            // changeForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 220);
            Controls.Add(groupBox1);
            Name = "changeForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Pass";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton changeRadioButton;
        private RadioButton forgotRadioButton;
        private Label label1;
        private TextBox newPassTextBox;
        private TextBox oldPassOrCodeTextBox;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private Button confirmButton;
        private Label label4;
        private Label oldPassOrCodeLabel;
        private Label label2;
    }
}