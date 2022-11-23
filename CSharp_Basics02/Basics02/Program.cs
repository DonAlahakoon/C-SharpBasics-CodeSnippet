using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //USER INPUT 

            Console.WriteLine("Enter your name");
            String username = Console.ReadLine();   //Taking string input 
            Console.WriteLine($"Hello {username}");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine()); //Taking string input and convert into int
            Console.WriteLine("You entered " + num);

            //ARRAYS

            int[] luckyNumbers = new int[10];
            //else int[] luckyNumbers  = {5,1,6,2,4,1,6};

            luckyNumbers[0] = 7;
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers.Length);


            //N DIMENSIONAL ARRAYS

            int[][] numberGrid = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            numberGrid[1][1] = 10;
            Console.WriteLine(numberGrid[1][1]);

            //ARRAYLIST

            ArrayList friends = new ArrayList();
            friends.Add("Oscar");
            friends.Add("Jini");
            friends.Add("Tom");


            Console.WriteLine(friends[0]);
            friends.Add("Hali");
            friends.Remove("Oscar");
            Console.WriteLine(friends.Contains("Oscar"));
            Console.WriteLine(friends.Count);

            //IF STATEMENTS

            bool isTall = false;
            bool isSmart = true;

            if (isTall && isSmart)
            {
                Console.WriteLine("He is smart and tall.");
            }
            else if(!isTall && isSmart)
            {
                Console.WriteLine("He is smart.");
            }
            else if(isTall && !isSmart)
            {
                Console.WriteLine("You are tall.");
            }
            else
            {
                Console.WriteLine("You are neither tall nor smart.");
            }

            if (1 < 3)
            {
                Console.WriteLine("Number comparison is true");
            }

            //SWITCH
            char grade = 'A';
            switch (grade)
            {
                case 'A': Console.WriteLine("You pass");break;
                case 'F': Console.WriteLine("You fail");break;

                default: Console.WriteLine("Invalid grade");break;
            }


            //WHILE LOOP
            int index = 1;
            while (index < 5)
            {
                index++;
                Console.WriteLine(index);
            }
            do
            {
                Console.WriteLine(index);
                index--;
            }while(index >1);


            //FOR LOOP
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            foreach(int i in luckyNumbers)
            {
                Console.WriteLine(i);
            }


            //Methods
            int sum = addNumbers(4, 13); //method declared below
            Console.WriteLine("Total:"+sum);

            Console.ReadLine();
        }

        public static int addNumbers(int v1, int v2)
        {
            return (v1 + v2);
        }
    }
}
