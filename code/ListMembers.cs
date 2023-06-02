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
    public partial class ListMembers : Form
    {
        public ListMembers()
        {
            InitializeComponent();
            string text = System.IO.File.ReadAllText(@"C:\Users\nina.vazae\Desktop\Recycling-main\code\detailes.txt");
            outputText.Text = $"Members:\n{text}";
        }

        private void returnText_Click(object sender, EventArgs e)
        {
            MenuSelect menuselect = new MenuSelect();
            menuselect.Show();
            Hide();
        }
    }
}
