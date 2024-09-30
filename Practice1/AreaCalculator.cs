namespace Practice1
{
    public abstract class Shape
    {
        public const double PI = 3.14;
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            if (radius < 0)
            {
                throw new ArgumentException("Впишите положительное значение");
            }
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Впишите положительные значения");
            }
            A = a;
            B = b;
            C = c;
        }
        public override double CalculateArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public bool isRight()
        {
            bool res = (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2));
            return res;
        }
    }

    public class ShapeAreaCalculator
    {
        public double Calculate(double radius)
        {
            return new Circle(radius).CalculateArea();
        }
        public double Calculate(double a, double b, double c)
        {
            return new Triangle(a, b, c).CalculateArea();
        }
    }
}
