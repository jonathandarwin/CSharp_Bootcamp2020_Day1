using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bootcamp_OOP
{
    class Dog
    {
        // Property
        public string name;
        public string color;
        public string type;
        public static int kaki;

        // Constructor
        public Dog(string name)
        {
            // this -> nunjuk ke kelas itu sendiri
            this.name = name;
            Console.WriteLine("Dog Created");
        }

        public Dog()
        {

        }

        // Method
        public void Bark()
        {
            Console.WriteLine("bark!");
        }

        public static void Eat()
        {
            Console.WriteLine("Dog Eat!");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name  : {0}", this.name);
            Console.WriteLine("Type  : {0}", this.type);
            Console.WriteLine("Color : {0}", this.color);
        }
    }
}
