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
    public partial class Home : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public Home()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void createTaskBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void allTaskBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {

            User_Task todo = micron.GetRecord<User_Task>($"task_title='{titleBox.Text}' AND task_description = '{descriptionBox2.Text}'");
            todo = new User_Task()
            {
                task_title = titleBox.Text,
                task_description = descriptionBox2.Text,
                task_time = timeBox.Text,
                task_date = dateBox.Text
            };
            if (titleBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter task title!");
                return;
            }
            if (descriptionBox2.Text.Length == 0)
            {
                MessageBox.Show("Please enter task description!");
                return;
            }

            if (String.IsNullOrEmpty(timeBox.Text))
            {
                MessageBox.Show("Please enter task end time!");
                return;
            }
            if (dateBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter task end date!");
                return;
            }
            todo = micron.Save(todo);
            //MessageBox.Show($" Task is added successfully");

        }
    }
}
