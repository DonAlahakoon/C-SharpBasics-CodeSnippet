using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            /*convention says start with a lowercase and additional worlds start with uppercase*/
            String name = "Mike";
            char testGrade = 'A';

            //short, int long can be pre-pended with 'u' for 'unsigned'
            byte age0 = 0;
            short age1 = 10;
            int age2 = 20;
            long age3 = 30L;

            float gpa0 = 2.5F;
            double gpa1 = 3.5;
            decimal gpa2 = 4.5M;

            bool isTall;
            isTall = false;

            name = "John";

            Console.WriteLine("Your name is " + name); //Mehod 1
            Console.WriteLine($"Your name is {name}");//Method 2

            //CASTING AND CONVERTING

            Console.WriteLine((int)3.14);
            Console.WriteLine((double)3);

            int intFromString = Convert.ToInt32("50");
            double doubleFromString = Convert.ToDouble("50.99");

            Console.WriteLine(100 + intFromString);
            Console.WriteLine(100 + doubleFromString);


            //STRINGS

            string greet = "Hello";
            //indexes       01234

            Console.WriteLine(greet.Length);
            Console.WriteLine(greet[1]);
            Console.WriteLine(greet.IndexOf("llo"));
            Console.WriteLine(greet.IndexOf("z"));
            Console.WriteLine(greet.Substring(2));
            Console.WriteLine(greet.Substring(1, 3));


            //NUMBERS

            Console.WriteLine(2 * 3);
            Console.WriteLine(10 % 3);
            Console.WriteLine(10 / 3.0 + "\n\n");

            int num = 19;
            num += 100;

            Console.WriteLine(num);

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Round(2.7));






            Console.ReadLine();
        }
    }
}
