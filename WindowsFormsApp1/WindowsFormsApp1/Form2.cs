using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string name;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string data) : this()
        {
            this.name = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.name != null)
                label1.Text = this.name;
            else
                label1.Text = "no name passed";
        }
    }
}
