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
            FibonacciSeries program = new FibonacciSeries();
            
            program.FibonacciSeries1();
            Console.ReadLine();
        }
    }
}
