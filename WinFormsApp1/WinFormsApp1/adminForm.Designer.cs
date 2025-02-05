namespace Library
{
    partial class adminForm
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
            usersListView = new ListView();
            removeUsersButton = new Button();
            editUsersButton = new Button();
            addUsersButton = new Button();
            searchUsersButton = new Button();
            usersTextBox = new TextBox();
            groupBox2 = new GroupBox();
            booksListView = new ListView();
            removeBooksButton = new Button();
            editBooksButton = new Button();
            addBooksButton = new Button();
            searchBooksButton = new Button();
            booksTextBox = new TextBox();
            groupBox3 = new GroupBox();
            lendingsListView = new ListView();
            removeLendingsButton = new Button();
            editLendingsButton = new Button();
            addLendingsButton = new Button();
            searchLendingsButton = new Button();
            lendingsTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usersListView);
            groupBox1.Controls.Add(removeUsersButton);
            groupBox1.Controls.Add(editUsersButton);
            groupBox1.Controls.Add(addUsersButton);
            groupBox1.Controls.Add(searchUsersButton);
            groupBox1.Controls.Add(usersTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users Manager";
            // 
            // usersListView
            // 
            usersListView.Location = new Point(6, 51);
            usersListView.Name = "usersListView";
            usersListView.Size = new Size(373, 153);
            usersListView.TabIndex = 5;
            usersListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Location = new Point(309, 22);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(70, 23);
            removeUsersButton.TabIndex = 4;
            removeUsersButton.Text = "Remove";
            removeUsersButton.UseVisualStyleBackColor = true;
            removeUsersButton.Click += removeUsersButton_Click;
            // 
            // editUsersButton
            // 
            editUsersButton.Location = new Point(233, 22);
            editUsersButton.Name = "editUsersButton";
            editUsersButton.Size = new Size(70, 23);
            editUsersButton.TabIndex = 3;
            editUsersButton.Text = "Edit";
            editUsersButton.UseVisualStyleBackColor = true;
            editUsersButton.Click += editUsersButton_Click;
            // 
            // addUsersButton
            // 
            addUsersButton.Location = new Point(157, 22);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(70, 23);
            addUsersButton.TabIndex = 2;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // searchUsersButton
            // 
            searchUsersButton.Location = new Point(81, 22);
            searchUsersButton.Name = "searchUsersButton";
            searchUsersButton.Size = new Size(70, 23);
            searchUsersButton.TabIndex = 1;
            searchUsersButton.Text = "Search";
            searchUsersButton.UseVisualStyleBackColor = true;
            searchUsersButton.Click += searchUsersButton_Click;
            // 
            // usersTextBox
            // 
            usersTextBox.Location = new Point(6, 22);
            usersTextBox.Name = "usersTextBox";
            usersTextBox.Size = new Size(69, 23);
            usersTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(booksListView);
            groupBox2.Controls.Add(removeBooksButton);
            groupBox2.Controls.Add(editBooksButton);
            groupBox2.Controls.Add(addBooksButton);
            groupBox2.Controls.Add(searchBooksButton);
            groupBox2.Controls.Add(booksTextBox);
            groupBox2.Location = new Point(403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Books Manager";
            // 
            // booksListView
            // 
            booksListView.Location = new Point(6, 51);
            booksListView.Name = "booksListView";
            booksListView.Size = new Size(373, 369);
            booksListView.TabIndex = 5;
            booksListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeBooksButton
            // 
            removeBooksButton.Location = new Point(309, 22);
            removeBooksButton.Name = "removeBooksButton";
            removeBooksButton.Size = new Size(70, 23);
            removeBooksButton.TabIndex = 4;
            removeBooksButton.Text = "Remove";
            removeBooksButton.UseVisualStyleBackColor = true;
            removeBooksButton.Click += removeBooksButton_Click;
            // 
            // editBooksButton
            // 
            editBooksButton.Location = new Point(233, 22);
            editBooksButton.Name = "editBooksButton";
            editBooksButton.Size = new Size(70, 23);
            editBooksButton.TabIndex = 3;
            editBooksButton.Text = "Edit";
            editBooksButton.UseVisualStyleBackColor = true;
            editBooksButton.Click += editBooksButton_Click;
            // 
            // addBooksButton
            // 
            addBooksButton.Location = new Point(157, 22);
            addBooksButton.Name = "addBooksButton";
            addBooksButton.Size = new Size(70, 23);
            addBooksButton.TabIndex = 2;
            addBooksButton.Text = "Add";
            addBooksButton.UseVisualStyleBackColor = true;
            addBooksButton.Click += addBooksButton_Click;
            // 
            // searchBooksButton
            // 
            searchBooksButton.Location = new Point(81, 22);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(70, 23);
            searchBooksButton.TabIndex = 1;
            searchBooksButton.Text = "Search";
            searchBooksButton.UseVisualStyleBackColor = true;
            searchBooksButton.Click += searchBooksButton_Click;
            // 
            // booksTextBox
            // 
            booksTextBox.Location = new Point(6, 22);
            booksTextBox.Name = "booksTextBox";
            booksTextBox.Size = new Size(69, 23);
            booksTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lendingsListView);
            groupBox3.Controls.Add(removeLendingsButton);
            groupBox3.Controls.Add(editLendingsButton);
            groupBox3.Controls.Add(addLendingsButton);
            groupBox3.Controls.Add(searchLendingsButton);
            groupBox3.Controls.Add(lendingsTextBox);
            groupBox3.Location = new Point(12, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 210);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lending Manager";
            // 
            // lendingsListView
            // 
            lendingsListView.Location = new Point(6, 51);
            lendingsListView.Name = "lendingsListView";
            lendingsListView.Size = new Size(373, 153);
            lendingsListView.TabIndex = 5;
            lendingsListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeLendingsButton
            // 
            removeLendingsButton.Location = new Point(309, 22);
            removeLendingsButton.Name = "removeLendingsButton";
            removeLendingsButton.Size = new Size(70, 23);
            removeLendingsButton.TabIndex = 4;
            removeLendingsButton.Text = "Remove";
            removeLendingsButton.UseVisualStyleBackColor = true;
            removeLendingsButton.Click += removeLendingsButton_Click;
            // 
            // editLendingsButton
            // 
            editLendingsButton.Location = new Point(233, 22);
            editLendingsButton.Name = "editLendingsButton";
            editLendingsButton.Size = new Size(70, 23);
            editLendingsButton.TabIndex = 3;
            editLendingsButton.Text = "Edit";
            editLendingsButton.UseVisualStyleBackColor = true;
            editLendingsButton.Click += editLendingsButton_Click;
            // 
            // addLendingsButton
            // 
            addLendingsButton.Location = new Point(157, 22);
            addLendingsButton.Name = "addLendingsButton";
            addLendingsButton.Size = new Size(70, 23);
            addLendingsButton.TabIndex = 2;
            addLendingsButton.Text = "Add";
            addLendingsButton.UseVisualStyleBackColor = true;
            addLendingsButton.Click += addLendingsButton_Click;
            // 
            // searchLendingsButton
            // 
            searchLendingsButton.Location = new Point(81, 22);
            searchLendingsButton.Name = "searchLendingsButton";
            searchLendingsButton.Size = new Size(70, 23);
            searchLendingsButton.TabIndex = 1;
            searchLendingsButton.Text = "Search";
            searchLendingsButton.UseVisualStyleBackColor = true;
            searchLendingsButton.Click += searchLendingsButton_Click;
            // 
            // lendingsTextBox
            // 
            lendingsTextBox.Location = new Point(6, 22);
            lendingsTextBox.Name = "lendingsTextBox";
            lendingsTextBox.Size = new Size(69, 23);
            lendingsTextBox.TabIndex = 0;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
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
        private GroupBox groupBox3;
        private ListView usersListView;
        private Button removeUsersButton;
        private Button editUsersButton;
        private Button addUsersButton;
        private Button searchUsersButton;
        private TextBox usersTextBox;
        private Button removeBooksButton;
        private Button editBooksButton;
        private Button addBooksButton;
        private Button searchBooksButton;
        private TextBox booksTextBox;
        private ListView lendingsListView;
        private Button removeLendingsButton;
        private Button editLendingsButton;
        private Button addLendingsButton;
        private Button searchLendingsButton;
        private TextBox lendingsTextBox;
        private ListView booksListView;
    }
}