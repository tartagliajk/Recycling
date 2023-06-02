using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static recycling.startSite;

namespace recycling
{
    public partial class ToF : Form
    {
        public ToF()
        {
            InitializeComponent();
            quizPanel.Visible = false;
        }

        private void returnToF_Click(object sender, EventArgs e)
        {
            MenuSelect menuSelect = new MenuSelect();
            menuSelect.Show();
            Hide();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            Globals.buttonClick = 0;
            quizPanel.Visible = true;
            startPanel.Visible = false;
        }

        private void optionTrue_Click(object sender, EventArgs e)
        {
            Globals.buttonClick++;
            tofGame();
        }

        private void optionFalse_Click(object sender, EventArgs e)
        {
            Globals.buttonClick++;
            tofGame();
        }

        public void tofGame()
        {
            string answerTxt = "Answer on the question before: ";

            answer.Text = $"{answerTxt}True";
            if (Globals.buttonClick == 1)
            {
                statement.Text = "Glass can be recycled many times.";
            }
            else if (Globals.buttonClick == 2)
            {
                answer.Text = $"{answerTxt}True";
                statement.Text = "Paper can not be recycled.";
            }
            else if(Globals.buttonClick == 3)
            {
                answer.Text = $"{answerTxt}False";
                statement.Text = "Recycling one aluminium can saves enough energy to run a TV for 4 hours";
            }else if(Globals.buttonClick == 4)
            {
                answer.Text = $"{answerTxt}True";
                statement.Text = "Recycling uses more energy than it saves.";
            }else if(Globals.buttonClick == 5)
            {
                answer.Text = $"{answerTxt}False";
                statement.Text = "Congrats on completing the True or False!" +
                    "\nPress the button to go back";
            }
        }
    }
}
