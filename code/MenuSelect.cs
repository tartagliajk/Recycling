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
    }
}
