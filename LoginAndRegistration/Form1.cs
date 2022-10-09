using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserRepository nekiIme = new UserRepository();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user = UserRepository.IsUser(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                MessageBox.Show("User " + user.FirstName  + " " + user.LastName + " is successfully Logged In!");
            } 
            else
            {
                MessageBox.Show("Entered credentials are not valid!");
            }
        }
    }
}
