# wozu-lesson7handson
c# class and inheritance 

# Part 1

Create a base class named Employee (don't forget the constructor). This class should contain the following string variables:
name
salary
hireDate
Add the following three methods to the Employee class — each should be virtual:
getName()
getSalary()
hiredDate()
Each of the above methods should print out the value of the corresponding variable along with a label.
See below for the output.
Create a subclass named Engineer that inherits from Employee and includes a new string variable, schoolAttended. Don't forget the constructor.
Within the Main method, instantiate a new Engineer object and call each of the methods (from # 2).
Your output should look similar to the following:
```
Employee Name: Rupert Scott
Salary: 42000
Hire Date: 11/22/12
```

# Part 2

Create a subclass of Engineer named SoftwareEngineer.
Within the new class, create a method that will override the getSalary() method and print "Salary: Sorry, this employee's salary is private.".
Create a new instance of the SoftwareEngineer class and call each of the three methods available.
Your output should now look similar to the following:
```
Employee Name: Rupert Scott
Salary: 42000
Hire Date: 11/22/12
---------------------------------------------------
Employee Name: Shea Rovington
Salary: Sorry, this employee's salary is private.
Hire Date: 03/27/18
```
