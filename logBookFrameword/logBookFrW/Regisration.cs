using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;


namespace logBookFrameword
{
     
    public partial class Regisration : Form
    {      
        MicronDbContext micron = new MicronDbContext();
       
        public Regisration()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
           
            User_Info user = micron.GetRecord<User_Info>($"username='{usernameTextBox .Text}'");
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

        }
    }
}
