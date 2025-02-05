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
    public partial class changeForgotPasswordForm : Form
    {
        public string username { get; set; } = string.Empty;
        public string oldPassOrCode{ get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string newPass { get; set; } = string.Empty;
        public bool changeOrForgot { get; set; } = true;
        public changeForgotPasswordForm()
        {
            InitializeComponent();
            changeRadioButton.Checked = true;
            forgotRadioButton.Checked = false;
        }

        private void changeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            oldPassOrCodeLabel.Text = "old password";
            changeOrForgot = true;
        }

        private void forgotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            oldPassOrCodeLabel.Text = "code";
            changeOrForgot = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Change password failed");
            }
        }
        private bool validateData()
        {
            if (ReadUsername() && ReadOldPassOrCode() && ReadEmail() && ReadNewPass())
            {
                MessageBox.Show("If code is correct the pass will be updated");
                return true;
            }
            MessageBox.Show("Please fill all fields");
            return false;
        }
        private bool ReadUsername()
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                username = usernameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid username");
                return false;
            }
            return true;
        }
        private bool ReadOldPassOrCode()
        {
            if (!string.IsNullOrEmpty(oldPassOrCodeTextBox.Text.Trim()))
            {
                oldPassOrCode = oldPassOrCodeTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid old password or code");
                return false;
            }
            return true;
        }
        private bool ReadEmail()
        {
            if (!string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                email = emailTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }
        private bool ReadNewPass()
        {
            if (!string.IsNullOrEmpty(newPassTextBox.Text.Trim()))
            {
                newPass = newPassTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid new password");
                return false;
            }
            return true;
        }
    }
}
