using System;
/*In method overriding a base class reference variable pointing to a child class object,
 will invoke the overridden method in the Child class*/

namespace Polymorphism
{
    public class Employee
    {
        public string Firstname = "Firstname";
        public string Lastname = "Lastname";

        public virtual void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }
    }
    //Here the base class is Virtual so that we can override that method to obtain our required values
    //Child class override the base class to obtain the required result
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname + " - FullTime Employee");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname + " - PartTime Employee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname + " - TemporaryEmployee");
        }
    }

    public class Poly
    {
        public static void employ()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
        }

        public static void intro()
        {
            Console.WriteLine("From here the Polymorphism Project Starts");
        }

    }
}
