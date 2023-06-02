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
    public partial class MenuSelect : Form
    {
        public MenuSelect()
        {
            InitializeComponent();
            menuWelcome.Text = $"Welcome {Globals.name}";
            if(Globals.status == "parent")
            {
                listAllKids.Visible = true;
            }
            else
            {
                listAllKids.Visible = false;
            }
        }

        private void reading_Click(object sender, EventArgs e)
        {
            reading Reading = new reading();
            Reading.Show();
            Hide();
        }

        private void Tof_Click(object sender, EventArgs e)
        {
            ToF tof = new ToF();
            tof.Show();
            Hide();
        }

        private void game_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            Hide();
        }

        private void listAllKids_Click(object sender, EventArgs e)
        {
            ListMembers listmembers = new ListMembers();
            listmembers.Show();
            Hide();
        }

        private void mTT_Click(object sender, EventArgs e)
        {
            matchTheTrash matchthetrash = new matchTheTrash();
            matchthetrash.Show();
            Hide();
        }

        private void gTT_Click(object sender, EventArgs e)
        {
            guessTT guestt = new guessTT();
            guestt.Show();
            Hide();
        }
    }
}
