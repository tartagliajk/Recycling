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
    public partial class reading : Form
    {
        public reading()
        {
            InitializeComponent();
        }

        private void generalBut_Click(object sender, EventArgs e)
        {
            readingTB.Text = "Recycling is how we take trash and transform it into new products. " +
                "There are several types of recycling processes that allow some materials to be " +
                "used one or more times. Recycling is good for us and the environment because it " +
                "reduces the use of new raw materials to product new products. It also reduces the " +
                "energy we use, improves the quality of air and water, and fights climate change." +
                "All sorts of things can be recycled. Some of the most common processes used today recycle:" +
                "\n• Plastics\n• Glass\n• Metals\n• Electronics\n• Computers and accessories\n• Textiles" +
                "\n• Newspapers and magazines" +
                "\n• Cardboard\nSoda cans, plastic water bottles, plastic milk cartons, newspapers, cereal boxes and old " +
                "computers are just some of the common items that are recycled every day. " +
                "If all of us were to recycle just a few items per day that we throw away, we can go a " +
                "long way to improving the environment for our futures and future generations.";
        }

        private void plasticBut_Click(object sender, EventArgs e)
        {
            readingTB.Text = "Plastic bottles to be recycled are collected from recycling points " +
                "and from the recycling bins in your neighborhood. The bottles are taken away in " +
                "big trucks to be sorted and smashed into big plastic blocks.\n\nThe blocks " +
                "can be many feet across and are taken to a recycling factor. They are chopped " +
                "into small plastic flakes – think small, colorful corn flakes. The flakes are " +
                "washed and dried and taken to be melted and made into new plastic items." +
                "\n\nFun facts about plastic recycling: A plastic bottle recycled can save as much " +
                "energy as it takes to light a 60 watt bulb for six hours! Also, old plastic " +
                "bottles can be turned into new products such as car parts, carpeting and clothes.";
        }

        private void glassBut_Click(object sender, EventArgs e)
        {
            readingTB.Text = "Glass is especially important to recycle because it will never decompose " +
                "in landfills. Here’s how it can be recycled:\n\nGlass bottles are thrown into " +
                "recycling bins, and the glass is picked up in trucks and taken to a glass treatment " +
                "facility. The glass is hand sorted by color and washed to get rid of contaminants. " +
                "The glass bottles are crushed and melted and molded into new jars and bottles." +
                "\n\nThe glass is sent back to stores in new products to be used again." +
                "\n\nFun facts about glass recycling: Glass does not degrade through recycling, so " +
                "it can be used endlessly. Also, old glass bottles can be used for new products such " +
                "as bricks and for many decorative uses.";
        }

        private void cardbordBut_Click(object sender, EventArgs e)
        {
            readingTB.Text = "Used cardboard is picked up from community recycling centers, offices, " +
                "stores and factories. All cardboard is sent to a waste cardboard company that puts " +
                "it into large bails to transport it to the paper mill. At the mill, a forklift picks " +
                "up the bales and puts them onto a conveyor. It is sent to the pulping machine.\n\nIn " +
                "the pulper, water anc chemicals are added to make a mushy, soggy pulp. The pulp is " +
                "purified and cleaned, ink removed and dried into flat rolls of paper.\n\nThe big " +
                "rolls of new paper are cut into smaller rolls and sold to customers that will make " +
                "them into all kinds of cardboard for packaging, containers and boxes." +
                "\n\nFun fact about cardboard recycling: Paper and cardboard comprise 30% of the " +
                "household trash we throw out, so recycling it is very important!";
        }

        private void returnText_Click(object sender, EventArgs e)
        {
            MenuSelect menuSelect = new MenuSelect();
            menuSelect.Show();
            Hide();
        }
    }
}
