using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bootcamp_Latihan
{
    class Job
    {
        public string company;
        public string position;
        public int salary;

        public Job()
        {

        }

        public Job(string company, string position, int salary)
        {
            this.company = company;
            this.position = position;
            this.salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Company     : {0}", this.company);
            Console.WriteLine("Position    : {0}", this.position);
            Console.WriteLine("Salary      : {0}", this.salary);
            Console.WriteLine();
        }
    }
}
