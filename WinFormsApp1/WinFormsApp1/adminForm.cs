using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class adminForm : Form
    {
        UserManager UserManager = new();
        User User = new();
        BookManager BookManager = new();
        LendingManager LendingManager = new();
        public adminForm(UserManager userManager, User user)
        {
            InitializeComponent();
            UserManager = userManager;
            User = user;
            InitializeUsersListView();
            InitializeBooksListView();
            InitializeLendingsListView();
            UpdateUsersListView();
            UpdateBooksListView();
            UpdateLendingsListView();
        }
        private void InitializeUsersListView()
        {
            usersListView.View = View.Details;
            usersListView.Columns.Add("Username", 100);
            usersListView.Columns.Add("Email", 100);
            usersListView.Columns.Add("Country", 70);
            usersListView.Columns.Add("Role", 50);
            usersListView.Columns.Add("RefId");
        }
        private void UpdateUsersListView()
        {
            usersListView.Items.Clear();
            foreach (User user in UserManager.Users)
            {
                ListViewItem item = new(user.Username);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Country);
                item.SubItems.Add(user.Role.ToString());
                item.SubItems.Add(user.Id);
                usersListView.Items.Add(item);
            }
        }
        private void InitializeBooksListView()
        {
            booksListView.View = View.Details;
            booksListView.Columns.Add("Title", 200);
            booksListView.Columns.Add("Author", 100);
            booksListView.Columns.Add("Free", 30);
            booksListView.Columns.Add("RefId");
        }
        private void UpdateBooksListView()
        {
            booksListView.Items.Clear();
            foreach (Book book in BookManager.Books)
            {
                Lending? lending = LendingManager.GetLendingByBookId(book.Id);
                ListViewItem item = new(book.Title);
                item.SubItems.Add(book.Author);
                if (lending == null)
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                item.SubItems.Add(book.Id);
                booksListView.Items.Add(item);
            }
        }
        private void InitializeLendingsListView()
        {
            lendingsListView.View = View.Details;
            lendingsListView.Columns.Add("Title", 200);
            lendingsListView.Columns.Add("User", 100);
            lendingsListView.Columns.Add("Due Date", 100);
            lendingsListView.Columns.Add("BookRefId");
            lendingsListView.Columns.Add("UserRefId");
        }
        private void UpdateLendingsListView()
        {
            lendingsListView.Items.Clear();
            foreach (Lending lending in LendingManager.Lendings)
            {
                Book? b = BookManager.GetBookById(lending.BookId);
                User? u = UserManager.GetUserById(lending.UserId);
                if (b == null || u == null)
                {
                    continue;
                }
                ListViewItem item = new(b.Title);
                item.SubItems.Add(u.FirstName + " " + u.LastName);
                item.SubItems.Add(lending.GetDueDate().ToString());
                item.SubItems.Add(lending.BookId);
                item.SubItems.Add(lending.UserId);
                lendingsListView.Items.Add(item);
            }
        }
        private void searchUsersButton_Click(object sender, EventArgs e)
        {
            usersListView.Items.Clear();
            foreach (User user in UserManager.Users)
            {
                if (user.Username.Contains(usersTextBox.Text) || user.FirstName.Contains(usersTextBox.Text) || user.LastName.Contains(usersTextBox.Text))
                {
                    ListViewItem item = new(user.Username);
                    item.SubItems.Add(user.Email);
                    item.SubItems.Add(user.Country);
                    item.SubItems.Add(user.Role.ToString());
                    usersListView.Items.Add(item);
                }
            }
        }
        private void addUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new("Add");
            registerForm.ShowDialog();
            if (registerForm.DialogResult == DialogResult.OK)
            {
                UserManager.Register(registerForm.User);
            }
            registerForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }
        private void editUsersButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            this.Hide();
            registerForm registerForm = new("Edit");
            registerForm.SetUser(UserManager.GetUserById(usersListView.SelectedItems[0].SubItems[4].Text));
            registerForm.ShowDialog();
            if (registerForm.DialogResult == DialogResult.OK)
            {
                UserManager.Register(registerForm.User);
                UserManager.DeRegister(UserManager.GetUserById(usersListView.SelectedItems[0].SubItems[4].Text));
            }
            registerForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }
        private void removeUsersButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            UserManager.DeRegister(UserManager.GetUserById(usersListView.SelectedItems[0].SubItems[4].Text));
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }
        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            booksListView.Items.Clear();
            foreach (Book book in BookManager.Books)
            {
                if(book.Title.Contains(booksTextBox.Text) || book.Author.Contains(booksTextBox.Text))
                {
                    Lending? lending = LendingManager.GetLendingByBookId(book.Id);
                    ListViewItem item = new(book.Title);
                    item.SubItems.Add(book.Author);
                    if (lending == null)
                    {
                        item.SubItems.Add("Yes");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    item.SubItems.Add(book.Id);
                    booksListView.Items.Add(item);
                }
            }
        }

        private void addBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookForm bookForm = new("Add");
            bookForm.ShowDialog();
            if (bookForm.DialogResult == DialogResult.OK)
            {
                BookManager.AddBook(bookForm.Book);
            }
            bookForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }

        private void editBooksButton_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book");
                return;
            }
            this.Hide();
            bookForm BookForm = new("Edit");
            BookForm.SetBook(BookManager.GetBookById(booksListView.SelectedItems[0].SubItems[3].Text));
            BookForm.ShowDialog();
            if (BookForm.DialogResult == DialogResult.OK)
            {
                BookManager.AddBook(BookForm.Book);
                BookManager.RemoveBook(BookManager.GetBookById(booksListView.SelectedItems[0].SubItems[3].Text));
            }
            BookForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }

        private void removeBooksButton_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book");
                return;
            }
            BookManager.RemoveBook(BookManager.GetBookById(booksListView.SelectedItems[0].SubItems[3].Text));
            UpdateBooksListView();
        }

        private void searchLendingsButton_Click(object sender, EventArgs e)
        {
            lendingsListView.Items.Clear();
            foreach (Lending lending in LendingManager.Lendings)
            {
                Book? b = BookManager.GetBookById(lending.BookId);
                User? u = UserManager.GetUserById(lending.UserId);
                if (b == null || u == null)
                {
                    continue;
                }
                if (b.Title.Contains(lendingsTextBox.Text) || b.Author.Contains(lendingsTextBox.Text) || u.Username.Contains(lendingsTextBox.Text) || u.FirstName.Contains(lendingsTextBox.Text) || u.LastName.Contains(lendingsTextBox.Text))
                {
                    ListViewItem item = new(b.Title);
                    item.SubItems.Add(u.FirstName + " " + u.LastName);
                    item.SubItems.Add(lending.GetDueDate().ToString());
                    item.SubItems.Add(lending.Id);
                    lendingsListView.Items.Add(item);
                }
            }
        }

        private void addLendingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lendingForm LendingForm = new("Add", UserManager, BookManager, LendingManager);
            LendingForm.ShowDialog();
            if (LendingForm.DialogResult == DialogResult.OK)
            {
                LendingManager.LendBook(LendingForm.BookId, LendingForm.UserId);
            }
            LendingForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }

        private void editLendingsButton_Click(object sender, EventArgs e)
        {
            if (lendingsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a lending");
                return;
            }
            this.Hide();
            lendingForm LendingForm = new("Edit", UserManager, BookManager, LendingManager);
            LendingForm.SetLending(LendingManager.GetLendingByIds(lendingsListView.SelectedItems[0].SubItems[3].Text, lendingsListView.SelectedItems[0].SubItems[4].Text), BookManager, UserManager);
            LendingForm.ShowDialog();
            if (LendingForm.DialogResult == DialogResult.OK)
            {
                LendingManager.LendBook(LendingForm.BookId, LendingForm.UserId);
                LendingManager.RemoveLending(LendingForm.Id);
            }
            LendingForm.Dispose();
            this.Show();
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }

        private void removeLendingsButton_Click(object sender, EventArgs e)
        {
            if (lendingsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a lending");
                return;
            }
            LendingManager.RemoveLending(LendingManager.GetLendingByIds(lendingsListView.SelectedItems[0].SubItems[3].Text, lendingsListView.SelectedItems[0].SubItems[4].Text).Id);
            UpdateBooksListView();
            UpdateLendingsListView();
            UpdateUsersListView();
        }
    }
}
