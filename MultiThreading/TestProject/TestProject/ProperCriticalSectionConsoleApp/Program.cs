using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperCriticalSectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 100;

            Parallel.For(0, iterations, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, (i) =>
            {
                ThreadingMethod();
            });

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static object _syncRoot = new object();

        public static int Count { get; set; }

        public static void ThreadingMethod()
        {
            int localCount = 0;

            lock (_syncRoot)
            {
                // Critical section
                localCount = ++Count;
                Console.WriteLine("Count is now " + Count);
            }

            // Use a slight delay to help show threading behavior
            System.Threading.Thread.Sleep(10);

            // Do more work here
            Console.WriteLine("Completing ThreadingMethod " + localCount + " execution.");
        }
    }
}
