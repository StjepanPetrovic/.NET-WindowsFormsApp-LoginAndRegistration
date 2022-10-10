using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginAndRegistration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User {
                // implementirati validaciju, not null
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };

            bool IsChecked = true;

            if (radBtnEmployee.Checked)
            {
                user.Status = UserType.Employee;
            }
            else if (radBtnGuest.Checked)
            {
                user.Status = UserType.Guest;
            }
            else if (radBtnAdministrator.Checked)
            {
                user.Status = UserType.Administrator;
            }
            else
            {
                MessageBox.Show("Please, select the user type.");

                IsChecked = false; 
            }

            if (IsChecked)
            {
                UserRepository.NewUser(user);

                Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
