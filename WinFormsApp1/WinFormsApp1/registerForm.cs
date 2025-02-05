using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Library
{
    public partial class registerForm : Form
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public User User => new(Id, Username, Password, Email, FName, LName, Country, Roles.User);
        public registerForm(string mode)
        {
            InitializeComponent();
            string json = File.ReadAllText("countries.json");
            List<string> countries = JsonConvert.DeserializeObject<List<string>>(json);
            countriesComboBox.DataSource = countries;
            Id = Guid.NewGuid().ToString();
            if (mode == "Register")
            {
                registerButton.Text = "Register";
            }
            else if (mode == "Add")
            {
                registerButton.Text = "Add";
            }
            else if (mode == "Edit")
            {
                registerButton.Text = "Edit";
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
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
            if (ReadUsername() && ReadPassword() && ReadEmail() && ReadFName() && ReadLName() && ReadCountry())
            {
                return true;
            }
            MessageBox.Show("Please fill all fields");
            return false;
        }
        private bool ReadUsername()
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                Username = usernameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid username");
                return false;
            }
            return true;
        }
        private bool ReadPassword()
        {
            if (!string.IsNullOrEmpty(passwordTextBox.Text.Trim()))
            {
                Password = passwordTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid password");
                return false;
            }
            return true;
        }
        private bool ReadEmail()
        {
            if (!string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                Email = emailTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }
        private bool ReadFName()
        {
            if (!string.IsNullOrEmpty(fNameTextBox.Text.Trim()))
            {
                FName = fNameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid first name");
                return false;
            }
            return true;
        }
        private bool ReadLName()
        {
            if (!string.IsNullOrEmpty(lNameTextBox.Text.Trim()))
            {
                LName = lNameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid last name");
                return false;
            }
            return true;
        }
        private bool ReadCountry()
        {
            if (!string.IsNullOrEmpty(countriesComboBox.Text.Trim()))
            {
                Country = countriesComboBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid country");
                return false;
            }
            return true;
        }
        public void SetUser(User user)
        {
            usernameTextBox.Text = user.Username;
            passwordTextBox.Text = user.Password;
            emailTextBox.Text = user.Email;
            fNameTextBox.Text = user.FirstName;
            lNameTextBox.Text = user.LastName;
            countriesComboBox.Text = user.Country;
            Id = user.Id;
        }
    }
}
