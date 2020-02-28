using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static TextBox PlaceTextBox()
        {            
            Point locationForTextBox = new Point();
            locationForTextBox.X_Ordinate = 20;
            locationForTextBox.Y_Ordinate = 30;
            Console.WriteLine(locationForTextBox.GetLocation());

            TextBox textBox = new TextBox();
            textBox.Name = "txtBox1";
            textBox.Text = "enter your name here";
            textBox.Location = locationForTextBox;
            return textBox;
        }
        static void Main(string[] args)
        {
            //Point locationForTextBox;
            //locationForTextBox.x_ordinate = 20;
            //locationForTextBox.y_ordinate = 30;

            //Point locationForTextBox = new Point(20,30);
            TextBox textBox = PlaceTextBox();

        }
    }
}
