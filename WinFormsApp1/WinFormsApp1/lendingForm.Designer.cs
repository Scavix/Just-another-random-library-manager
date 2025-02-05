namespace Library
{
    partial class lendingForm
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
            dateTimePicker = new DateTimePicker();
            bookComboBox = new ComboBox();
            userComboBox = new ComboBox();
            okButton = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(bookComboBox);
            groupBox1.Controls.Add(userComboBox);
            groupBox1.Controls.Add(okButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lending Manage";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(73, 80);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(121, 23);
            dateTimePicker.TabIndex = 11;
            // 
            // bookComboBox
            // 
            bookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(73, 51);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(121, 23);
            bookComboBox.TabIndex = 10;
            // 
            // userComboBox
            // 
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(73, 22);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(121, 23);
            userComboBox.TabIndex = 9;
            // 
            // okButton
            // 
            okButton.Location = new Point(6, 109);
            okButton.Name = "okButton";
            okButton.Size = new Size(188, 35);
            okButton.TabIndex = 8;
            okButton.Text = "Add";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // lendingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 169);
            Controls.Add(groupBox1);
            Name = "lendingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lending Manage Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button okButton;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private ComboBox bookComboBox;
        private ComboBox userComboBox;
    }
}