using System;
/*This Project is of Method Hiding 
 In method hiding a base class reference variable pointing to a child class object, will
 invoke the hidden method in the Base Class*/


namespace Methodhiding
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;

        public void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }
    }
    //We are creating a child class for the parent class, when called the parent class will be hided and the child class will be called
    //The method inside the child class will be executed and the result inside the child class will be obtained.
    //If there is no method inside the child class then the main class method will be executed.
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
            //base will call the main class and execute the main class methods
            Console.WriteLine(Firstname + " " + Lastname + "-Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {
    }
    public class Result{
        public static void print()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Devi Prasad";
            FTE.Lastname = "Tikkisetti";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Jagadish";
            PTE.Lastname = "Tikkisetti";
            PTE.PrintFullName();


            //Parent Class can call the child class, but child class cannot call the parent class
            Employee PT = new PartTimeEmployee();
            PT.Firstname = "Jai";
            PT.Lastname = "Naidu";
            PT.PrintFullName();

            //using the type cast
            PartTimeEmployee PTM = new PartTimeEmployee();
            PTM.Firstname = "PartTime";
            PTM.Lastname = "Employee";
            ((Employee)PTM).PrintFullName();
        }

        public static void intro()
        {
            Console.WriteLine("Here starts the Methodhiding Project - Employee Class");
        }
    }
}
