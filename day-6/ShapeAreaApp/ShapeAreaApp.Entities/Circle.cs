using System;

namespace ShapeAreaApp.Entities
{
    public class Circle : IShapeArea
    {
        private double _radius;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
