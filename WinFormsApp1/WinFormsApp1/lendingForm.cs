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
    public partial class lendingForm : Form
    {
        public string Id { get; set; } = string.Empty;
        public string BookId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public DateTime LendDate { get; set; } = DateTime.Now;
        public Lending Lending => new(Id, BookId, UserId, LendDate);
        public lendingForm(string mode, UserManager um, BookManager bm, LendingManager lm)
        {
            InitializeComponent();
            Id = Guid.NewGuid().ToString();
            userComboBox.DataSource = um.Users.Select(user => $"{user.FirstName} {user.LastName}@{user.Id}").ToList();
            bookComboBox.DataSource = bm.Books
                .Where(book => !lm.Lendings.Select(lending => lending.BookId).Contains(book.Id))
                .Select(book => $"{book.Title}@{book.Id}")
                .ToList();
            if (mode == "Add")
            {
                okButton.Text = "Add";
            }
            else if (mode == "Edit")
            {
                okButton.Text = "Edit";
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Registration failed");
            }
        }
        private bool validateData()
        {
            if (ReadBook() && ReadUser() && ReadDateTime())
            {
                return true;
            }
            return false;
        }
        private bool ReadBook()
        {
            if (bookComboBox.SelectedItem != null)
            {
                BookId = bookComboBox.SelectedItem.ToString().Split("@")[1];
                return true;
            }
            MessageBox.Show("Invalid book");
            return false;
        }
        private bool ReadUser()
        {
            if (userComboBox.SelectedItem != null)
            {
                UserId = userComboBox.SelectedItem.ToString().Split("@")[1];
                return true;
            }
            MessageBox.Show("Invalid user");
            return false;
        }
        private bool ReadDateTime()
        {
            if (dateTimePicker.Value < DateTime.Today.AddDays(1))
            {
                LendDate = dateTimePicker.Value;
                return true;
            }
            MessageBox.Show("Invalid date");
            return false;
        }
        public void SetLending(Lending lending, BookManager bm, UserManager um)
        {
            Id = lending.Id;
            bookComboBox.SelectedItem = bm.Books.Find(b => b.Id == lending.BookId).Title + "@" + lending.BookId;
            userComboBox.SelectedItem = um.Users.Find(u => u.Id == lending.UserId).FirstName + " " + um.Users.Find(u => u.Id == lending.UserId).LastName + "@" + lending.UserId;
            dateTimePicker.Value = LendDate;
        }
    }
}
