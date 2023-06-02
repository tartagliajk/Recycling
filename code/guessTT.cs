using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static recycling.startSite;

namespace recycling
{
    public partial class guessTT : Form
    {
        public guessTT()
        {
            InitializeComponent();
            Globals.pointCounter = 0;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(Globals.pointCounter == 2)
            {
                guessingPanel.Visible = false;
                label1.Text = "You won!";
            }
            else if(cardboardPic.Visible == true && cardboardB.Checked == true)
            {
                label1.Text = "You were correct";
                cardboardPic.Visible = false;
                plasticPic.Visible = true;
                Globals.pointCounter++;
            }else if(plasticPic.Visible == true && plasticB.Checked == true)
            {
                label1.Text = "You were correct";
                plasticPic.Visible = false;
                glassPic.Visible = true;
                Globals.pointCounter++;
            }else if(glassPic.Visible == true && glassB.Checked == true)
            {
                label1.Text = "You were correct";
                Globals.pointCounter++;
            }
        }

        private void returnSign_Click(object sender, EventArgs e)
        {
            MenuSelect menuselect = new MenuSelect();
            menuselect.Show();
            Hide();
        }
    }
}
