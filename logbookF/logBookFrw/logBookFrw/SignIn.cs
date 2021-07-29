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
    public partial class SignIn : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public SignIn()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            //User_Info user = micron.GetRecord<User_Info>($"username='{usernameTextBox.Text}' AND first_name = '{firstNameTextBox.Text}'");
            //if password match user password
            /*string pass = passwordtextBox.Text;
            string userN = usernametextBox.Text;

            if (String.IsNullOrEmpty(usernametextBox.Text))
            {
                MessageBox.Show("Invalid username");
                return;
            }
            if (String.IsNullOrEmpty(passwordtextBox.Text))
            {
                MessageBox.Show("Invalid password");
            }
            User_Info user = micron.GetRecord<User_Info>($"username='{usernametextBox.Text}' AND password = '{passwordtextBox.Text}'");

            if (user == null)
            {
                MessageBox.Show("Invalid username or password! Please try again!");
                return;
            }
            else
            {
            */
                Home home = new Home();
                home.ShowDialog();
                this.Close();

           // }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
