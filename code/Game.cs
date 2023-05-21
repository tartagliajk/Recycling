using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recycling
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            inputPanel.Visible = false;
            trashDisplay.Visible = false;
            File.WriteAllText("C:\\Users\\nina.vazae\\Desktop\\recycling\\trashcans.txt", String.Empty);
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
            var i = 0;
            trashCan trashCan = trashCans[i];
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
