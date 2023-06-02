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
    public partial class matchTheTrash : Form
    {
        public matchTheTrash()
        {
            InitializeComponent();
            Globals.pointCounter = 0;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Globals.pointCounter == 2)
            {
                trashPanel.Visible = false;
                tCPanel.Visible = false;
                Submit.Visible = false;
                victoryText.Visible = true;
            }else if (plasticB.Checked == true && plasticTCB.Checked == true)
            {
                plasticTrash.Visible = false;
                plasticTC.Visible = false;
                plasticB.Visible = false;
                plasticTCB.Visible = false;
                Globals.pointCounter++;
            }else if(cardboardB.Checked == true && cardboardTCB.Checked == true)
            {
                cardboardTrash.Visible = false;
                cardboardTC.Visible = false;
                cardboardB.Visible = false;
                cardboardTCB.Visible = false;
                Globals.pointCounter++;
            }
            else if(glassB.Checked == true && glassTCB.Checked == true)
            {
                glassTrash.Visible = false;
                glassTC.Visible = false;
                glassB.Visible = false;
                glassTCB.Visible = false;
                Globals.pointCounter++;
            }
        }

        private void returnSign_Click(object sender, EventArgs e)
        {
            MenuSelect menuSelect = new MenuSelect();
            menuSelect.Show();
            Hide();
        }
    }
}
