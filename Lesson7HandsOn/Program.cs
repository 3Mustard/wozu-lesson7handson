using System;

namespace Lesson7HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer e1 = new Engineer("Matt", "200,000", "3/3/2033", "None");
            e1.getName();   // Employee Name: Matt
            e1.getSalary(); // Salary: 200,000
            e1.hiredDate(); // Hire Date: 3 / 3 / 2033

            SoftwareEngineer e2 = new SoftwareEngineer("Chaeyoung", "3mil", "idk", "None");
            e2.getName(); // Employee Name: Chaeyoung
            e2.getSalary(); // Salary: Sorry, this employee's salary is private.
            e2.hiredDate(); // Hire Date: idk
        }
    }

    public class Employee
    {
        public string Name 
            { get; set; }
        public string Salary 
            { get; set; }
        public string HireDate 
            { get; set; }

        public Employee() 
        {
            Name = "default";
            Salary = "default";
            HireDate = "default";
        }

        public Employee(string name, string salary, string hireDate)
        {
            Name = name;
            Salary = salary;
            HireDate = hireDate;
        }

        public virtual void getName()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }

        public virtual void getSalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }

        public virtual void hiredDate() 
        {
            Console.WriteLine($"Hire Date: {HireDate}");
        }
    }

    public class Engineer : Employee
    {
        public string SchoolAttended 
            { get; set; }

        public Engineer(string name, string salary, string hireDate, string schoolAttended) 
            : base(name, salary, hireDate) 
        {
            SchoolAttended = schoolAttended;
        }
    }

    public class SoftwareEngineer : Engineer 
    {
        public SoftwareEngineer(string name, string salary, string hireDate, string schoolAttended) 
            : base(name, salary, hireDate, schoolAttended) 
        { 
        }

        public override void getSalary()
        {
            Console.WriteLine("Salary: Sorry, this employee's salary is private.");
        }
    }
}
