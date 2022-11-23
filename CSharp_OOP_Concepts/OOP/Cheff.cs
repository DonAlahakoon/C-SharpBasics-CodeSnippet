using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cheff
    {
        String name;
        int age;
        public Cheff(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void makeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void makeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void makeSpecialDish() //virtual means that method can overriden
        {
            Console.WriteLine("The chef makes fried rice");
        }
    }

    class ItalianCheff : Cheff
    {
        public string ctryOfOrigin;
        public ItalianCheff(string name,int age,String ctryOfOrigin) : base(name,age)
        {
            this.ctryOfOrigin = ctryOfOrigin ;
        }
        public void makePasta()
        {
            Console.WriteLine("Chef makes pasta");
        }
        public override void makeSpecialDish() // override the method of super class
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}
