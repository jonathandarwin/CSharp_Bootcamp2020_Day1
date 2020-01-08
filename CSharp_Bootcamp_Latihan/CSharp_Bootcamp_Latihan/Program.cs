using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bootcamp_Latihan
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        List<Person> personList = new List<Person>();
        public Program()
        {
            int menu = -1;
            do
            {
                menu = -1;
                Console.Clear();
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. View Person");
                Console.WriteLine("3. Delete Person");
                Console.WriteLine("4. Exit");

                do
                {
                    try
                    {
                        Console.Write(">> ");
                        menu = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
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
                        Delete();
                        break;
                    case 4:
                        Console.WriteLine("Thankyou ^,^");
                        break;
                }

                Console.WriteLine("Press ENTER to continue");
                Console.ReadKey();
            }
            while (menu != 4);
        }

        private void Add()
        {
            string name = "";
            int age = 0;
            string company = "";
            string position = "";
            int salary = 0;

            Console.Write("Input Name : ");
            name = Console.ReadLine();

            Console.Write("Input Age : ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Input Company : ");
            company = Console.ReadLine();

            do
            {
                Console.Write("Input Position [Staff | Officer | Manager] : ");
                position = Console.ReadLine();
            }
            while (!position.Equals("Staff") && !position.Equals("Officer") && !position.Equals("Manager"));

            do
            {
                Console.Write("Input Salary [1.000.000 - 10.000.000] : ");
                salary = int.Parse(Console.ReadLine());
            }
            while (salary < 1000000 || salary > 10000000);

            Job job = new Job(company, position, salary);
            Person person = new Person(name, age, job);
            personList.Add(person);

            Console.WriteLine("Insert Success");            
        }

        private void View()
        {
            if(personList.Count == 0)
            {
                Console.WriteLine("No Data");
                return;
            }

            foreach(Person person in personList)
            {
                person.PrintInfo();
            }
        }

        private void Delete()
        {
            View();
            if(personList.Count != 0)
            {
                int idx = -1;

                do
                {
                    Console.Write("Input Index [1-{0}] [type `0` to exit] : ", personList.Count);
                    idx = int.Parse(Console.ReadLine());
                }
                while (idx < 0 || idx > personList.Count);

                if(idx != 0)
                {
                    personList.RemoveAt(idx - 1);

                    Console.WriteLine("Delete Success");
                }                
            }
        }
    }
}
