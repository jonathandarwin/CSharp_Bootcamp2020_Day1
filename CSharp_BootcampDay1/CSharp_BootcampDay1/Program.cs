using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BootcampDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }



        public Program()
        {
            x(10);
            y(10);
            Console.ReadKey();
        }        

        void Print(List<int> nilai)
        {
            if(nilai.Count == 0)
            {
                Console.WriteLine("No Data");
                return;
            }

            for (int i = 0; i < nilai.Count; i++)
            {
                Console.WriteLine("Nilai {0} : {1}", (i + 1), nilai.ElementAt(i));
            }
            Console.WriteLine("");
        }
    }
}
