namespace ShapeHierarchy_Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("------------------MENU--------------------");
                Console.WriteLine("1.Calculate Area and perimeter of Circle");
                Console.WriteLine("2.Calculate Area and perimeter of Rectangle ");
                Console.WriteLine("3.Calculate Area and perimeter of Triangle");
                Console.WriteLine("4.Exit the program");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Radius of the Circle :");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine("Area of Circle is : " + circle.CalculateArea());
                        Console.WriteLine("Perimeter of Circle is :" + circle.CalculatePerimeter());
                        break;
                    case 2:
                        Console.WriteLine("Enter the length of the rectangle");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the breadth of the rectangle");
                        double breadth = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(length, breadth);
                        Console.WriteLine("Area of rectangle is :" + rectangle.CalculateArea());
                        Console.WriteLine("Perimeter of rectangle is : " + rectangle.CalculatePerimeter());
                        break;
                    case 3:
                        Console.WriteLine("Enter the Side 1 of triangle");
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the side 2 of triangle");
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the side 3 of the triangle");
                        double side3 = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(side1, side2, side3);
                        Console.WriteLine("Area of Triangle is :" + triangle.CalculateArea());
                        Console.WriteLine("perimeter of triangle is: " + triangle.CalculatePerimeter());
                        break;
                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (true);
        }
    }
}