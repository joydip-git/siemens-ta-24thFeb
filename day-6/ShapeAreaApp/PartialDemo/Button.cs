using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class Button
    {
        string text;
        public event EventHandler Click;
        public string Text { get => text; set => text = value; }
    }
}
