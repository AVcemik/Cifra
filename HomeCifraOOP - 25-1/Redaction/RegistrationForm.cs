using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redaction
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

        }

        private void btRegistr_Click(object sender, EventArgs e)
        {
            RegistrateNewUser();
        }
        private void RegistrateNewUser()
        {
            string userName = tbUsername.Text;
            string password = tbPassword.Text;
            string firstName = tbFirstName.Text;
            string secondName = tbSecondName.Text;
            string email = tbEmail.Text;
            DateTime birthDay = dtpBirthDay.Value;
            User newUser = new User(userName, password, firstName, secondName, email, birthDay);
            UserRegistration.RegisterUser(newUser);
        }
        private void CloseForm()
        {
            RegistrationForm.ActiveForm.Close();
            Form1.ActiveForm.Show();
        }
    }
}
