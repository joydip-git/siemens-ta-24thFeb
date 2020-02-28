using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    public class TextBox
    {
        string name;
        string text;
        Point location;

        public TextBox()
        {

        }
        public TextBox(string name, string text, Point location)
        {
            this.name = name;
            this.text = text;
            this.location = location;
        }

        public string Name { get => name; set => name = value; }
        public string Text { get => text; set => text = value; }
        public Point Location { get => location; set => location = value; }
    }
}
