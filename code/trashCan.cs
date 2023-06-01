using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recycling
{
    public class trashCan
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Color { get; set; }

        public string Item { get; set; }

        public trashCan(string id, string name, string color, string item)
        {
            Id = id;
            Name = name;
            Color = color;
            Item = item;
        }
    }
}
