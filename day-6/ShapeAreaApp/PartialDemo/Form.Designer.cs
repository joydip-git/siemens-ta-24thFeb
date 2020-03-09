using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    partial class Form1
    {
        string text;
        string size;
        string location;
        Button button1;

        public string Text { get => text; set => text = value; }
        public string Size { get => size; set => size = value; }
        public string Location { get => location; set => location = value; }
        private void InitializeComponent()
        {
            button1 = new Button();
            this.button1.Text = "Click";
            System.EventHandler ev = new EventHandler(this.ButtonClicked);
            this.button1.Click += ev;


            this.size = "10,20";
            this.location = "30,40";
            this.text = "Form1";
        }

    }
}
