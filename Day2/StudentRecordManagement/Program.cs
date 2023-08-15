namespace StudentRecordManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            do
            {
                Console.WriteLine(" Select an option: ");
                Console.WriteLine("1. Add Student ");
                Console.WriteLine("2. Display Student List");
                Console.WriteLine("3. Calculate Overall GPA");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice:");

                int choice = int.Parse(Console.ReadLine());


                

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of student: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter student gender: ");
                        string gender = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter student Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of courses enrolled: ");

                        int numCourses = int.Parse(Console.ReadLine());

                        List<string> courseEnrollment = new List<string>();
                        for (int i = 0; i < numCourses; i++)
                        {
                            Console.WriteLine("Enter the course name:");
                            string course = Console.ReadLine();
                            courseEnrollment.Add(course);
                        }
                        Student student = new Student();
                        school.AddStudent(name, age, gender, id, courseEnrollment);
                        Console.WriteLine("Student added successfully");
                        break;
                    case 2:
                        school.DisplayStudents();
                        break;
                    case 3:
                        Console.WriteLine("Enter number of courses");
                        int num = Convert.ToInt32(Console.ReadLine());
                        List<char> grades = new List<char>();

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Enter the grades");
                            char input = Convert.ToChar(Console.ReadLine().ToUpper());

                            if (input.Equals('A') || input.Equals('B') || input.Equals('C') || input.Equals('D'))
                            {
                                grades.Add(input);
                            }
                            else
                            {
                                --i;
                                Console.WriteLine("Enter a valid grade");
                            }
                        }
                        double result = school.CalculateGPA(grades);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (true);
        }
    }
}