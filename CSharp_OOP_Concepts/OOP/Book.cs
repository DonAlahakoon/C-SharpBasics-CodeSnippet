using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Book
    {
        public string title;
        public string author;
        public static string staticAttribute = "My Static Attribute";

        public void ReadBook()
        {
            Console.WriteLine($"Reading {this.title} by {this.author}");// this used to denote specific instance
        }
    }
    class App
    {
        public string name;
        public int num;
        public App(string name, int num)
        {
            this.setName(name);
            this.setNum(num);
        }
        public void setName(String name) {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setNum(int num)
        {
            this.num = num;
        }
        public int getNum()
        {
            return this.num;
        }
        public void displayDetails()
        {
            Console.WriteLine("App name:"+this.getName());
            Console.WriteLine("App number:"+this.getNum());
        }
    }
}
