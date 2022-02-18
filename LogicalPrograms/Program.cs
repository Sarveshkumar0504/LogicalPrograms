using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            //FibonacciSeries program = new FibonacciSeries();

            //program.FibonacciSeries1();
            //PrimeNumber program = new PrimeNumber();
            //program.PrimeNumber1();
            // ReverseNumber program = new ReverseNumber();
            //program.ReverseNumber1();
            PerfectNumber program = new PerfectNumber();
            program.PerfectNumber1();
            Console.ReadLine();
        }
    }
}
