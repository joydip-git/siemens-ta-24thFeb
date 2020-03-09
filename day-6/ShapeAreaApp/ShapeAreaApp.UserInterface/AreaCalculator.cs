using ShapeAreaApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeAreaApp.UserInterface
{
    public partial class AreaCalculator : Form
    {
        public AreaCalculator()
        {
            InitializeComponent();
        }

        private void AreaCalculator_Load(object sender, EventArgs e)
        {
            panelShape.Visible = false;
        }

        private void radioCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCircle.Checked)
            {
                panelShape.Visible = true;

                textBoxBase.Visible = false;
                textBoxHeight.Visible = false;
                lblBase.Visible = false;
                lblHeight.Visible = false;


                textBoxRadius.Visible = true;
                lblRadius.Visible = true;

                btnCalculateArea.Text = "Calculate Area of Circle";
            }
            else
            {
                panelShape.Visible = false;
            }
        }

        private void radioTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTriangle.Checked)
            {
                panelShape.Visible = true;

                textBoxBase.Visible = true;
                textBoxHeight.Visible = true;
                lblBase.Visible = true;
                lblHeight.Visible = true;

                textBoxRadius.Visible = false;
                lblRadius.Visible = false;

                btnCalculateArea.Text = "Calculate Area of Triangle";
            }
            else
            {
                panelShape.Visible = false;
            }
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            IShapeArea shape = null;
            if (radioCircle.Checked)
            {
                double radius = double.Parse(textBoxRadius.Text);
                shape = new Circle(radius);
            }
            else if (radioTriangle.Checked)
            {
                double tBase = double.Parse(textBoxBase.Text);
                double tHeight = double.Parse(textBoxHeight.Text);
                shape = new Triangle(tBase, tHeight);
            }

            if (shape != null)
                Calculate(shape);
            else
                MessageBox.Show("no shape found...");

        }
        private void Calculate(IShapeArea shape)
        {
            Type typeOfShape = shape.GetType();
            double area = shape.CalculateArea();
            MessageBox.Show($"Area of {typeOfShape} is {area}");
        }
    }
}
