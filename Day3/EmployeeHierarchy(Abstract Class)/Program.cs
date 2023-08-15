namespace EmployeeHierarchy_Abstract_Class_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee employee;
            do
            {
                Console.WriteLine("Press 1 for Manager ");
                Console.WriteLine("Press 2 for Developer ");
                Console.WriteLine("Press 3 for SalesPerson");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employee = new Manager(1, "John", 90000);
                        employee.DisplayDetails();
                        break;
                    case 2:
                        employee = new Developer(2, "Mary", 5000);
                        employee.DisplayDetails();

                        break;
                    case 3:
                        employee = new SalesPerson(3, "Anne", 30000);
                        employee.DisplayDetails();

                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (true);
        }
    }
}



    









