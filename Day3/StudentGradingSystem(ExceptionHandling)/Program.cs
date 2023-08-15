namespace StudentGradingSystem_ExceptionHandling_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] grades;
            Console.WriteLine("Enter the name of student");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of subjects");
            int noOfSubjects = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(name,noOfSubjects);
            student.EnterGrades();

            student.DisplayDetails();
        }
    }
}