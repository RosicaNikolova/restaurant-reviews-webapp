
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;

namespace DesktopApplication
{
    public partial class LoginForm : Form
    {
        LoginManager loginManager = new LoginManager(new UserRepository());
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            try
            {
                user = loginManager.Login(txbEmail.Text, txbPassword.Text);
                if(user.Roles == Role.USER)
                {
                    MessageBox.Show("You can login in the website.");
                }
                else
                {
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                }
            }
            catch (LoginException)
            {
                MessageBox.Show("Invalid crenetials. Please, try again");
            }
        }
    }
}
