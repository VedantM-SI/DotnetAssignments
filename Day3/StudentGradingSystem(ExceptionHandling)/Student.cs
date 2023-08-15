using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem_ExceptionHandling_
{
    internal class Student
    {
        public string Name { get; set; }
        private double[] grades;

        public Student(string name, int noOfSubjects)
        {
            Name = name;
            grades = new double[noOfSubjects];
        }

        public void EnterGrades()
        {
            bool validInput = false;
            while (!validInput)
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    Console.WriteLine($"Enter the grades for subject{i + 1}:");
                    string input = (Console.ReadLine());

                    if (double.TryParse(input, out double grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Grade must be between 0 to 100");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Enter a numeric value");
                    }
                }
            }
        }


        public double CalculateAverage()
        {
            double total = 0;
            foreach (double grade in grades)
            {
                total += grade;
            }
            return total/grades.Length;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name:{Name}\nGrades:{String.Join("," ,grades)}\nAverage grade:{CalculateAverage()}");
        }
    }
}
   
