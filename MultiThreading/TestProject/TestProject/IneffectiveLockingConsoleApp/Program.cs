using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IneffectiveLockingConsoleApp
{
    /// <summary>
    /// This program shows how locking more than what's needed reduces multithreading efficiency.
    /// This output will always be in sequential order because it's effectively single threaded.
    /// </summary>
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
            // NOTE:  No work is being done outside the lock.
            lock (_syncRoot)
            {
                // Critical section
                ++Count;
                Console.WriteLine("Count is now " + Count);
                Console.WriteLine("Completing ThreadingMethod " + Count + " execution.");
            }
        }
    }
}
