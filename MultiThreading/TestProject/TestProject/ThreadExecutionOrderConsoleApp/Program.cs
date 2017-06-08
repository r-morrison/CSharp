using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExecutionOrderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine("My i value is " + i);
            });

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
