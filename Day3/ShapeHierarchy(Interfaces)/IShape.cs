using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy_Interfaces_
{
    internal interface IShape
    {
        public double CalculateArea();
        public double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.CalculateArea());
            Console.WriteLine(this.CalculatePerimeter());
        }
    }
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public double CalculateArea()
        {
            return Length * Breadth;
        }
        public double CalculatePerimeter()
        {
            return 2 * (Length + Breadth);
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.CalculateArea());
            Console.WriteLine(this.CalculatePerimeter());
        }
    }
    class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2,double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double CalculateArea() 
        {
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public void DisplayDetails()
        {
            Console.WriteLine(this.CalculateArea());
            Console.WriteLine(this.CalculatePerimeter());
        }


    }

}
