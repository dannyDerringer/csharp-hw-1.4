using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();

            employee1.FirstName = "John";
            employee1.LastName = "Smith";
            employee1.Salary = 69000;

            employee2.FirstName = "John";
            employee2.LastName = "Wick";
            employee2.Salary = 79000;

            employee3.FirstName = "John";
            employee3.LastName = "Williams";
            employee3.Salary = 89000;

            employee4.FirstName = "John";
            employee4.LastName = "Doe";
            employee4.Salary = 99000;

            employee5.FirstName = "John";
            employee5.LastName = "The Baptist";
            employee5.Salary = 59000;

            employee6.FirstName = "John";
            employee6.LastName = "Jacob Jingleheimer Schmidt";
            employee6.Salary = 109000;

            List<Employee> Company = new List<Employee>();
            Company.Add(employee1);
            Company.Add(employee2);
            Company.Add(employee3);
            Company.Add(employee4);
            Company.Add(employee5);
            Company.Add(employee6);

            foreach (Employee employee in Company)
            {
                employee.giveraise(10);
            }
        }

    }
    
    public class Employee
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public int Salary{get; set;}

        public void giveraise(int r)
        {
            int oldsalary = this.Salary;
            int raise = oldsalary / r;
            int newsalary = (oldsalary + raise);

            this.Salary = newsalary;

            Console.WriteLine(this.FirstName + " " + this.LastName + " has received a "
            + r +"% raise.");

            Console.WriteLine("New Salary: $" + this.Salary + "    Old Salary: $" + oldsalary);
            Console.WriteLine();
        }

    }
}
