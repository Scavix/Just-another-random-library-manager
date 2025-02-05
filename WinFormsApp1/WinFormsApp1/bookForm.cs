using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Library
{
    public partial class bookForm : Form
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public Book Book => new(Id, Title, Author, Genre, ISBN);
        public bookForm(string mode)
        {
            InitializeComponent();
            Id = Guid.NewGuid().ToString();
            genresComboBox.DataSource = Enum.GetValues(typeof(Genres));
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
            if (ReadTitle() && ReadAuthor() && ReadGenre() && ReadISBN())
            {
                return true;
            }
            MessageBox.Show("Please fill all fields");
            return false;
        }
        private bool ReadTitle()
        {
            if (!string.IsNullOrEmpty(titleTextBox.Text.Trim()))
            {
                Title = titleTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid title");
                return false;
            }
            return true;
        }
        private bool ReadAuthor()
        {
            if (!string.IsNullOrEmpty(authorTextBox.Text.Trim()))
            {
                Author = authorTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid author");
                return false;
            }
            return true;
        }
        private bool ReadGenre()
        {
            if (genresComboBox.SelectedItem != null)
            {
                Genre = genresComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Invalid genre");
                return false;
            }
            return true;
        }
        private bool ReadISBN()
        {
            if (!string.IsNullOrEmpty(ISBNTextBox.Text.Trim()))
            {
                ISBN = ISBNTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid ISBN");
                return false;
            }
            return true;
        }
        public void SetBook(Book book)
        {
            titleTextBox.Text = book.Title;
            authorTextBox.Text = book.Author;
            genresComboBox.SelectedItem = book.Genre;
            ISBNTextBox.Text = book.ISBN;
            Id = book.Id;
        }
    }
}
