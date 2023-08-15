using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentRecordManagement
{
    internal class School
    {
        List<Student> students = new List<Student>();


       
        public void AddStudent(string name,int age,string gender,int id,List<String> courseEnrollment)
        {
            Student newStudent = new Student(name,age,gender,id,courseEnrollment);
            students.Add(newStudent);
        }

        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, GPA: {student.Gpa}");
                Console.WriteLine("Enrolled Courses:");
                foreach (string course in student.CourseEnrollment)
                {
                    Console.WriteLine($"- {course}");
                }
                Console.WriteLine();
            }   

        }

        public double CalculateGPA(List<char> courseGrades)
        {
            
            int numCourses=0;

            double gpa = 0;
            foreach(char g in courseGrades)
            {
                numCourses++;
                switch (g){
                case 'A':
                        gpa += 4;
                        break;
                    case 'B':
                        gpa += 3;
                        break;
                    case 'C':
                        gpa += 2;
                        break;
                    case 'D':
                        gpa += 1;
                        break;
                    default:
                        gpa += 0;
                        break;

                    }
                }
            gpa = gpa / numCourses;
            return gpa;
           

        }
    }
}
