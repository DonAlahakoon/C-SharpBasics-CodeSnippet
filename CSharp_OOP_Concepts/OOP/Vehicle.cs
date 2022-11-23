using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Vehicle
    {
        public abstract void move(); //abstract method

        public void getDescrption()
        {
            Console.WriteLine("Vehicles are used for transportation");
        }
    }
    class Bicycle : Vehicle //inheriting the abstract class
    {
        public override void move()
        {
            Console.WriteLine("Bicycle pedals forward.");
        }
    }
    class Plane : Vehicle //inheriting the abstract class
    {
        public override void move()// overriding abstract method
        {
            Console.WriteLine("Plane flies through the sky");
        }
    }
}
