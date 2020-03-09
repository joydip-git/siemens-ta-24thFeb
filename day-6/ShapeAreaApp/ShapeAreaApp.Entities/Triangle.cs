namespace ShapeAreaApp.Entities
{
    public class Triangle : IShapeArea
    {
        private double _tBase;
        private double _tHeight;

        public Triangle()
        {

        }
        public Triangle(double tBase, double tHeight)
        {
            _tBase = tBase;
            _tHeight = tHeight;
        }

        public double TBase { get => _tBase; set => _tBase = value; }
        public double THeight { get => _tHeight; set => _tHeight = value; }

        public double CalculateArea()
        {
            return 0.5 * _tHeight * _tBase;
        }
    }
}
