using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal interface Animals
    {
        void Speak();

    }
    public class Dog : Animals
    {
        public void Speak()
        {
            Console.WriteLine("Woof woof");
        }
    }
    public class Cat : Animals
    {
        public void Speak()
        {
            Console.WriteLine("Meaw meaw");
        }
    }
}
