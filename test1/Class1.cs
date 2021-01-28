using System;

namespace test1
{
    public class Employee
    {
        public string Name;
        
        public string Salary
        { get; set; }
        public string HireDate
        { get; set; }

        public Employee()
        {
            this.Name = "default";
            this.Salary = "default";
            this.HireDate = "default";
        }

        public Employee(string name, string salary, string hireDate)
        {
            this.Name = name;
            this.Salary = salary;
            this.HireDate = hireDate;
        }

        public virtual void getName()
        {
            Console.WriteLine($"Employee Name: {this.Name}");
        }

        public virtual void getSalary()
        {
            Console.WriteLine($"Salary: {this.Salary}");
        }

        public virtual void hiredDate()
        {
            Console.WriteLine($"Hire DAte: {this.HireDate}");
        }
    }

    public class Engineer : Employee
    {
        public string SchoolAttended
        { get; set; }

        public Engineer(string name, string salary, string hireDate, string schoolAttended)
            : base(name, salary, hireDate)
        {
            this.SchoolAttended = schoolAttended;
        }

    }
}
