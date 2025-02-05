using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class loginForm : Form
    {
        private UserManager UserManager = new();
        public loginForm()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username == null || password == null) {
                MessageBox.Show("Please enter username and password");
                return;
            }
            else
            {
                User logged = new();
                bool isLogged = false;
                foreach (var user in UserManager.Users)
                {
                    if (username == user.Username && password == user.Password)
                    {
                        logged = user;
                        isLogged = true;
                        break;
                    }   
                }
                if (isLogged)
                {
                    if(logged.Role == Roles.Admin)
                    {
                        this.Hide();
                        adminForm adminForm = new(UserManager, logged);
                        adminForm.ShowDialog();
                        if (adminForm.DialogResult == DialogResult.OK)
                        {
                            adminForm.Dispose();
                            this.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.Hide();
                        userForm userForm = new(logged);
                        userForm.ShowDialog();
                        if (userForm.DialogResult == DialogResult.OK)
                        {
                            userForm.Dispose();
                            this.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
        }
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm registerForm = new("Register");
            registerForm.ShowDialog();
            if (registerForm.DialogResult == DialogResult.OK)
            {
                UserManager.Register(registerForm.User);
                registerForm.Dispose();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void changeForgotPasswordlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            changeForgotPasswordForm changeForgotPasswordForm = new();
            changeForgotPasswordForm.ShowDialog();
            if (changeForgotPasswordForm.DialogResult == DialogResult.OK)
            {
                UserManager.UpdatePassword(changeForgotPasswordForm.username, changeForgotPasswordForm.email, changeForgotPasswordForm.oldPassOrCode, changeForgotPasswordForm.newPass);
                changeForgotPasswordForm.Dispose();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}