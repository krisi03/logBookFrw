using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Micron;

namespace logBookFrw
{
    public partial class Registration : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void userRegister_Click(object sender, EventArgs e)
        {
            User_Info user = micron.GetRecord<User_Info>($"username='{usernameTextBox.Text}' AND first_name = '{firstNameTextBox.Text}'");
            user = new User_Info()
            {
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                email = emailTextBox.Text,
                username = usernameTextBox.Text,
                password_u = passwordTextBox.Text,
                phone_number = phoneTextBox.Text,
                company_name = companyTextBox.Text

            };

            if(passwordTextBox.Text != confirmPswdTextBox.Text) {
                MessageBox.Show("password does not match!");
                return;
            }
            if (firstNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter your first name!");
                return;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter your last name!");
                return;
            }
            
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter username!");
                return;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("In order to protect your profile enter a password!");
                return;
            }
            List<User_Info> usersExisting = micron.GetRecords<User_Info>("SELECT username FROM user_info").ToList();
            List<User_Info> emailsExisting = micron.GetRecords<User_Info>("SELECT email FROM user_info").ToList();

            foreach (var username in usersExisting)
            {
                if (username.username == usernameTextBox.Text)
                {
                    MessageBox.Show("This username is already taken!");
                    return;
                }
            }

            foreach (var email in emailsExisting)
            {
                if (email.email == emailTextBox.Text)
                {
                    MessageBox.Show("This email is already used by another user!");
                    return;
                }
            }

            user = micron.Save(user);
            MessageBox.Show($"{firstNameTextBox.Text} register successfully");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPswdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
