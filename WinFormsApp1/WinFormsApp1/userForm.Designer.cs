namespace Library
{
    partial class userForm
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
            searchReturnButton = new Button();
            returnButton = new Button();
            searchReturnTextBox = new TextBox();
            lendingListView = new ListView();
            groupBox2 = new GroupBox();
            searchBorrowTextBox = new TextBox();
            borrowButton = new Button();
            searchBorrowButton = new Button();
            borrowListView = new ListView();
            groupBox3 = new GroupBox();
            lendingsLabel = new Label();
            label5 = new Label();
            countryLabel = new Label();
            label4 = new Label();
            usernameLabel = new Label();
            label7 = new Label();
            emailLabel = new Label();
            lNameLabel = new Label();
            fNameLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchReturnButton);
            groupBox1.Controls.Add(returnButton);
            groupBox1.Controls.Add(searchReturnTextBox);
            groupBox1.Controls.Add(lendingListView);
            groupBox1.Location = new Point(12, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Active lendings";
            // 
            // searchReturnButton
            // 
            searchReturnButton.Location = new Point(223, 21);
            searchReturnButton.Name = "searchReturnButton";
            searchReturnButton.Size = new Size(75, 23);
            searchReturnButton.TabIndex = 3;
            searchReturnButton.Text = "Search";
            searchReturnButton.UseVisualStyleBackColor = true;
            searchReturnButton.Click += searchReturnButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(304, 21);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(75, 23);
            returnButton.TabIndex = 2;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // searchReturnTextBox
            // 
            searchReturnTextBox.Location = new Point(6, 22);
            searchReturnTextBox.Name = "searchReturnTextBox";
            searchReturnTextBox.Size = new Size(211, 23);
            searchReturnTextBox.TabIndex = 1;
            // 
            // lendingListView
            // 
            lendingListView.Location = new Point(6, 51);
            lendingListView.Name = "lendingListView";
            lendingListView.Size = new Size(373, 263);
            lendingListView.TabIndex = 0;
            lendingListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(searchBorrowTextBox);
            groupBox2.Controls.Add(borrowButton);
            groupBox2.Controls.Add(searchBorrowButton);
            groupBox2.Controls.Add(borrowListView);
            groupBox2.Location = new Point(403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrow menu";
            // 
            // searchBorrowTextBox
            // 
            searchBorrowTextBox.Location = new Point(6, 22);
            searchBorrowTextBox.Name = "searchBorrowTextBox";
            searchBorrowTextBox.Size = new Size(211, 23);
            searchBorrowTextBox.TabIndex = 3;
            // 
            // borrowButton
            // 
            borrowButton.Location = new Point(304, 22);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(75, 23);
            borrowButton.TabIndex = 2;
            borrowButton.Text = "Borrow";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // searchBorrowButton
            // 
            searchBorrowButton.Location = new Point(223, 22);
            searchBorrowButton.Name = "searchBorrowButton";
            searchBorrowButton.Size = new Size(75, 23);
            searchBorrowButton.TabIndex = 1;
            searchBorrowButton.Text = "Search";
            searchBorrowButton.UseVisualStyleBackColor = true;
            searchBorrowButton.Click += searchBorrowButton_Click;
            // 
            // borrowListView
            // 
            borrowListView.Location = new Point(6, 51);
            borrowListView.Name = "borrowListView";
            borrowListView.Size = new Size(373, 369);
            borrowListView.TabIndex = 0;
            borrowListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lendingsLabel);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(countryLabel);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(usernameLabel);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(emailLabel);
            groupBox3.Controls.Add(lNameLabel);
            groupBox3.Controls.Add(fNameLabel);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 104);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal infos";
            // 
            // lendingsLabel
            // 
            lendingsLabel.AutoSize = true;
            lendingsLabel.Location = new Point(277, 80);
            lendingsLabel.Name = "lendingsLabel";
            lendingsLabel.Size = new Size(38, 15);
            lendingsLabel.TabIndex = 11;
            lendingsLabel.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 80);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Lendings";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(277, 51);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(38, 15);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 51);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Country";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(277, 22);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(38, 15);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "label4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 22);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Username";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(74, 80);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(38, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "label6";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new Point(74, 51);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new Size(38, 15);
            lNameLabel.TabIndex = 4;
            lNameLabel.Text = "label5";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new Point(74, 22);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new Size(38, 15);
            fNameLabel.TabIndex = 3;
            fNameLabel.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "userForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User: ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button searchReturnButton;
        private Button returnButton;
        private TextBox searchReturnTextBox;
        private ListView lendingListView;
        private TextBox searchBorrowTextBox;
        private Button borrowButton;
        private Button searchBorrowButton;
        private ListView borrowListView;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label emailLabel;
        private Label lNameLabel;
        private Label fNameLabel;
        private Label lendingsLabel;
        private Label label5;
        private Label countryLabel;
        private Label label4;
        private Label usernameLabel;
        private Label label7;
    }
}