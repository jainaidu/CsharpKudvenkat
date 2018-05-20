using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using Methodhiding;
using Polymorphism;



class Customer
{
    string _firstname;
    string _lastname;

    //Here i am building a Constructor
    public Customer(string Firstname, string Lastname)
    {
        this._firstname = Firstname;
        this._lastname = Lastname;
    }
    
    //This Constructor does not take any parameters
    //Default parametes are already provided inside the constructor itself
    //No Need of providing any Parameters inside the Main Method.
    public Customer() : this("No First Name Provided", "No Last Name Provided")
    {

    }
    //Method - {0} is called as place holder
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstname + " " + this._lastname);
    }

    //This is a Destructor, they dont take parameters or no return values
    ~Customer()
    {
        //Used to clean any resources, clean the code
        //called automatically by the garbage collector
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer C1 = new Customer("Jagadish", "Tikkisetti");
        C1.PrintFullName();

        Customer C2 = new Customer();
        C2.PrintFullName();
    //Test Project methods are called here
        Circle.test();
        Circle.solution();
    //Methodhiding Project Methods are called here
        Result.intro();
        Result.print();

        //Polymorphism Project is starting here
        Poly.intro();
        Poly.employ();

    }
 }

