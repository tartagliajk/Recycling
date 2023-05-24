using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static recycling.startSite;

namespace recycling
{
    public partial class Game : Form
    {
        public Game()
        {
            File.WriteAllText("C:\\Users\\nina.vazae\\Desktop\\main-folder\\code\\trashcans.txt", String.Empty);
            InitializeComponent();
            inputPanel.Visible = false;
            trashDisplay.Visible = false;
        }

        public class systemCreate
        {
            public static trashCanSystem system = trashCanSystem.GetInstance();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            inputPanel.Visible = true;
            startBut.Visible = false;
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            Globals.i++;
            void addCan()
            {
                var id = (systemCreate.system.getCans().Count + 1).ToString();
                string name = nameBox.Text;
                string item = trashBox.Text;
                string color = colorBox.Text;

                trashCan newTrash = new trashCan(id, name, color, item);
                systemCreate.system.addCan(newTrash);
            }
            addCan();
            inputPanel.Visible = false;
            trashDisplay.Visible = true;
            List<trashCan> trashCans = systemCreate.system.getCans();
            trashCan trashCan = trashCans[Globals.i];
            nameDisplay.Text = $"Name: {trashCan.Name}";
            itemDisplay.Text = $"Item: {trashCan.Item}";
            colorDisplay.Text = $"Color: {trashCan.Color}";
        }

        private void returnStartM_Click(object sender, EventArgs e)
        {
            MenuSelect menuselect = new MenuSelect();
            menuselect.Show();
            Hide();
        }
    }
}
