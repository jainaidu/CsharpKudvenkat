using System;

namespace Test
{
    public class Circle
    {

        public static void test()
        {
            Console.WriteLine("This is Circle project");
        }
        //static float _PI = 3.141F;
        // float _PI = 3.141F;
        static float _PI;
        int _Radius;
        //this is used to call the instance of the class
        //if the class has static variables this cannot be used for it

        static Circle()
        {
            //Earlier we are storing the PI value as a instance which is called everytime for each Circle.
            //Here we used a static constructor where it stores the static values and can be used everytime, 
            //This will increase the efficiency of the program
            Circle._PI = 3.141F;
        }

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            //return this._PI * this._Radius * this._Radius;
            return Circle._PI * this._Radius * this._Radius;
        }

        public static void solution()
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area of the first circle = {0}", Area1);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area of the second circle = {0}", Area2);

            
        }
        
    }
}
