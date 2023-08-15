using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    internal class Student
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public List<string> CourseEnrollment { get; set; }

        public double Gpa { get; }

       

        public Student() { }


        public Student(string name, int age, string gender, int id, List<string> courseEnrollment)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Id = id;
            CourseEnrollment = courseEnrollment;
           
        }

       /* public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Gender: {Gender} ID: {Id}";
        }*/

    }
}
