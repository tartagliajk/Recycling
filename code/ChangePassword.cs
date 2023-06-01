using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recycling
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void logInSubmit_Click(object sender, EventArgs e)
        {
            submit.Visible = false;
            var writtenName = nameBox.Text;
            var writtenPassword = passwordBox.Text;

            var users = File.ReadAllText(@"C:\Users\nina.vazae\Desktop\Recycling-main\code\detailes.txt").Split(',').ToList().Where(x => !String.IsNullOrWhiteSpace(x));

            List<User> myUsers = new List<User>();
            foreach (var user in users)
            {
                var information = user.Split(' ');
                User temp = new User();
                temp.Name = information[0].Trim();
                temp.Password = information[1].Trim();
                temp.status = information[2].Trim();
                myUsers.Add(temp);
            }

            var selectedUser = myUsers.Where(x => x.Name == writtenName).SingleOrDefault();
            myUsers.Remove(selectedUser);
            selectedUser.Password = writtenPassword;
            myUsers.Add(selectedUser);

            List<string> formatForFile = new List<string>();
            foreach (var item in myUsers)
            {
                formatForFile.Add(item.PrepareForFile());
            }
            File.WriteAllLines(@"C:\Users\nina.vazae\Desktop\Recycling-main\code\detailes.txt", formatForFile.ToArray());

            label2.Text = "The password has been changed";
        }

        private void returnText_Click(object sender, EventArgs e)
        {
            startSite startsite = new startSite();
            startsite.Show();
            Hide();
        }

        private class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string status { get; set; }

            public string PrepareForFile()
            {
                return Name + " " + Password + " " + status + ",";
            }
        }
    }
}
