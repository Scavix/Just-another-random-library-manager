namespace Library
{
    partial class bookForm
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
            genresComboBox = new ComboBox();
            okButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ISBNTextBox = new TextBox();
            authorTextBox = new TextBox();
            titleTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(genresComboBox);
            groupBox1.Controls.Add(okButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ISBNTextBox);
            groupBox1.Controls.Add(authorTextBox);
            groupBox1.Controls.Add(titleTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Manage";
            // 
            // genresComboBox
            // 
            genresComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genresComboBox.FormattingEnabled = true;
            genresComboBox.Location = new Point(94, 80);
            genresComboBox.Name = "genresComboBox";
            genresComboBox.Size = new Size(100, 23);
            genresComboBox.TabIndex = 9;
            // 
            // okButton
            // 
            okButton.Location = new Point(6, 138);
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
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(94, 109);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(100, 23);
            ISBNTextBox.TabIndex = 3;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(94, 51);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(100, 23);
            authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(94, 22);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 0;
            // 
            // bookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 198);
            Controls.Add(groupBox1);
            Name = "bookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manage Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ISBNTextBox;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private Button okButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox genresComboBox;
    }
}