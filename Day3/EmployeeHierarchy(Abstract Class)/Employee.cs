using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy_Abstract_Class_
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public abstract double CalculateBonus();

        protected const double managerBonus = 0.4;//40
        protected const double developerBonus = 0.2;//20%
        protected double salesPersonBonus = 0.1;//10%

        public Employee() { }

        public Employee(int employeeId, string name, double salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;

        }
        public  void DisplayDetails()
        {
            Console.WriteLine($" EmployeeId: {EmployeeId}\tName: {Name} \tSalary: {Salary} Bonus: {CalculateBonus()}");
        }




    }

    class Manager : Employee
    {
        public Manager() { }
        public Manager(int employeeId, string name, double salary) : base(employeeId, name, salary) { }



        public override double CalculateBonus()
        {
            return Salary * developerBonus;
        }
       


    }
    class Developer : Employee
    {
        public Developer(int employeeId, string name, double salary) : base(employeeId, name, salary) { }

        public Developer() { }
        public override double CalculateBonus()
        {
            return Salary * managerBonus;
        }
        
    }
    class SalesPerson : Employee
    {
        public SalesPerson() { }
        public SalesPerson(int employeeId, string name, double salary) : base(employeeId, name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * salesPersonBonus;
        }
       
    }
}
