using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bootcamp_Latihan
{
    class Person
    {
        public string name;
        public int age;
        public Job job;

        public Person()
        {

        }

        public Person(string name, int age, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name : {0}", this.name);
            Console.WriteLine("Age  : {0}", this.age);
            job.PrintInfo();
        }

        public void Update(string name, int age, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }
}
