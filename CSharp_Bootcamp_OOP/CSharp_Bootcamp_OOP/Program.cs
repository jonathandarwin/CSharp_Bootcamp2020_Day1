using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bootcamp_OOP
{
    class Program
    {        
        static void Main(string[] args)
        {
            new Program();            
        }

        private List<Dog> dogList = new List<Dog>();

        public Program()
        {
            int menu = -1;
            
            do
            {
                menu = -1;
                Console.WriteLine("1. Add Dog");
                Console.WriteLine("2. View Dog");
                Console.WriteLine("3. Remove Dog");
                Console.WriteLine("4. Exit");

                do
                {                    
                    try
                    {                        
                        Console.Write(">> ");
                        menu = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);                               
                        menu = -1;                        
                    }                    
                }
                while (menu < 1 || menu > 4);

                switch (menu)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        Remove();
                        break;
                    case 4:
                        Console.WriteLine("Thankyou ^,^");
                        break;
                }

                Console.ReadKey();
            }
            while (menu != 4);
        }

        void Add()
        {
            string name = "";
            string color = "";
            string type = "";

            Console.WriteLine("Input name : ");
            name = Console.ReadLine();

            Console.WriteLine("Input color : ");
            color = Console.ReadLine();

            Console.WriteLine("Input type : ");
            type = Console.ReadLine();

            // Create Object
            Dog dog = new Dog();
            dog.name = name;
            dog.type = type;
            dog.color = color;

            // Add to List
            dogList.Add(dog);

            Console.WriteLine("Insert Success");
            Console.WriteLine("Press ENTER to continue");
        }

        void View()
        {
            foreach(Dog dog in dogList)
            {
                dog.PrintInfo();
                Console.WriteLine();
            }
        }

        void Remove()
        {
            if(dogList.Count == 0)
            {
                Console.WriteLine("No Data");
                return;
            }

            View();

            int idx = -1;
            do
            {
                Console.Write("Input index [1-{0}] : ", dogList.Count);
                idx = int.Parse(Console.ReadLine());
            }
            while (idx < 1 || idx > dogList.Count);

            dogList.RemoveAt(idx - 1);
            Console.WriteLine("Remove Success");
            Console.WriteLine("Press ENTER to continue");
        }
    }
}
