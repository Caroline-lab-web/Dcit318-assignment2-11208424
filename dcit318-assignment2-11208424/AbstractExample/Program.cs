using System;

namespace AbstractExample
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(3, 4);
            Shape square = new Square(5);

            Console.WriteLine("Triangle Area: " + triangle.Area());
            Console.WriteLine("Square Area: " + square.Area());
        }
    }
}