using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exception handling
            try
            {
                Console.WriteLine("Enter a number");
                int division = 10 / Convert.ToInt32(Console.ReadLine()); // if 0 is input then exception is occur
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e);
            }


            //General object creation( class without a constructor)
            Book b = new Book();
            b.title = "HarryPotter";
            b.author = "JK Rowling";
            b.ReadBook();
            Console.WriteLine(Book.staticAttribute);


            //Creating object from class with a constructor
            App a = new App("mobile", 2);
            a.displayDetails();


            // I N H E R I T A N C E

            Cheff c = new Cheff("Gordan Ramsay", 50);
            c.makeChicken();
            c.makeSpecialDish();

            ItalianCheff i = new ItalianCheff("Massimo Bottura", 32, "Italy");
            i.makePasta();
            i.makeChicken();
            i.makeSpecialDish();
            

            // A B S T R A C T I O N 
            Plane p = new Plane(); //plane is a class which inherit abstract class vehicle
            p.move();



            //Implementing  I N T E R F A C E S 
            Animals[] animals =
            {
                new Dog(),
                new Cat()
            };
            foreach(Animals animal in animals)
            {
                animal.Speak();
            }

            Console.ReadLine();
        }

    }
}
