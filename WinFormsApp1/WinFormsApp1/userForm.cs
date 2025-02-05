using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    public partial class userForm : Form
    {
        private BookManager BookManager = new();
        private LendingManager LendingManager = new();
        private User User = new();
        public userForm(User u)
        {
            InitializeComponent();
            User = u;
            this.Text += u.Id;
            fNameLabel.Text = u.FirstName;
            lNameLabel.Text = u.LastName;
            emailLabel.Text = u.Email;
            countryLabel.Text = u.Country;
            usernameLabel.Text = u.Username;
            lendingsLabel.Text = LendingManager.GetLendingsByUserId(u.Id).Count.ToString();
            InitialiseLendingListView();
            InitialiseBorrowListView();
            UpdateLendingListView();
            UpdateBorrowListView();
            UpdateCount();
        }
        private void searchBorrowButton_Click(object sender, EventArgs e)
        {
            borrowListView.Items.Clear();
            foreach (Book b in BookManager.Books)
            {
                if (b.Title.Contains(searchBorrowTextBox.Text) || b.Author.Contains(searchBorrowTextBox.Text))
                {
                    Lending? lending = LendingManager.GetLendingByBookId(b.Id);
                    ListViewItem item = new(b.Title);
                    item.SubItems.Add(b.Author);
                    if (lending == null)
                    {
                        item.SubItems.Add("Yes");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    item.SubItems.Add(b.Id);
                    borrowListView.Items.Add(item);
                }
            }
        }
        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (borrowListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book");
                return;
            }
            if (borrowListView.SelectedItems[0].SubItems[2].Text == "No")
            {
                MessageBox.Show("Book is not available");
                return;
            }
            LendingManager.LendBook(borrowListView.SelectedItems[0].SubItems[3].Text, User.Id);
            UpdateBorrowListView();
            UpdateLendingListView();
            UpdateCount();
        }
        private void searchReturnButton_Click(object sender, EventArgs e)
        {
            lendingListView.Items.Clear();
            foreach (Lending l in LendingManager.GetLendingsByUserId(User.Id))
            {
                Book? book = BookManager.GetBookById(l.BookId);
                if (book == null)
                {
                    continue;
                }
                if (book.Title.Contains(searchReturnTextBox.Text) || book.Author.Contains(searchReturnTextBox.Text))
                {
                    ListViewItem item = new(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(l.GetDueDate().ToString());
                    lendingListView.Items.Add(item);
                }
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (lendingListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a lending");
                return;
            }
            LendingManager.ReturnBook(lendingListView.SelectedItems[0].SubItems[3].Text);
            UpdateBorrowListView();
            UpdateLendingListView();
            UpdateCount();
        }
        public void InitialiseLendingListView()
        {
            lendingListView.View = View.Details;
            lendingListView.Columns.Add("Title", 200);
            lendingListView.Columns.Add("Author", 100);
            lendingListView.Columns.Add("Due Date", 100);
            lendingListView.Columns.Add("RefId");
        }
        public void InitialiseBorrowListView()
        {
            borrowListView.View = View.Details;
            borrowListView.Columns.Add("Title", 200);
            borrowListView.Columns.Add("Author", 100);
            borrowListView.Columns.Add("Free", 30);
            borrowListView.Columns.Add("RefId");
        }
        public void UpdateLendingListView()
        {
            lendingListView.Items.Clear();
            foreach (Lending l in LendingManager.Lendings)
            {
                if (l.UserId != User.Id)
                {
                    continue;
                }
                Book? book = BookManager.GetBookById(l.BookId);
                if (book == null)
                {
                    continue;
                }
                ListViewItem item = new(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(l.GetDueDate().ToString());
                item.SubItems.Add(l.BookId);
                lendingListView.Items.Add(item);
            }
        }
        public void UpdateBorrowListView()
        {
            borrowListView.Items.Clear();
            foreach (Book b in BookManager.Books)
            {
                Lending? lending = LendingManager.GetLendingByBookId(b.Id);
                ListViewItem item = new(b.Title);
                item.SubItems.Add(b.Author);
                if (lending == null)
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                item.SubItems.Add(b.Id);
                borrowListView.Items.Add(item);
            }
        }
        public void UpdateCount()
        {
            lendingsLabel.Text = LendingManager.GetLendingsByUserId(User.Id).Count.ToString();
        }
    }
}