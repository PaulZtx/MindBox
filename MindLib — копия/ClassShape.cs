namespace MindLib
{

    public static class Shape
    {
        private const double Pi = Math.PI;
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static double GetSquare(double r)
        {
            return Math.Round(Pi * r * r, 3);
        }
        /// <summary>
        /// Площадь треугольника 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
        }
        /// <summary>
        /// Площадь четырехугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="alpha"></param>
        /// <param name="beta"></param>
        /// <returns></returns>
        public static double GetSquare(double a, double b, double c, double d, int alpha = 90, int beta = 90)
        {
            double p = (a + b + c + d) / 2;
            double S = (p - a) * (p - b) * (p - c) * (p - d);
            return Math.Round(Math.Sqrt(S - a * b * c * d * Math.Pow(Math.Cos((alpha + beta) / 2), 2)), 3);
        }

        /// <summary>
        /// Площадь фигуры с неизвестным типом
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public static double GetSquare(Figure figure) => figure.GetSquare();

    }

    public abstract class Figure
    {
        protected const double Pi = Math.PI;
        public string Name { get; private set; }

        public Figure(string name)
        {
            Name = name;
        }

        public abstract double GetSquare();
    }
    
    public class Circle: Figure
    {
        private double _rad;

        public Circle(string name, double r) : base(name)
        {
            _rad = r;
        }

        public override double GetSquare()
        {
            return Math.Round(Pi * _rad * _rad, 3);
        }
    }
    
    public class Triangle: Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetSquare()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), 3);
        }

        public bool IsRectangular()
        {
            return _a * _a == _b * _b + _c * _c ||
                    _b * _b == _a * _a + _c * _c ||
                    _c * _c == _b * _b + _a * _a;
        }
    }
}