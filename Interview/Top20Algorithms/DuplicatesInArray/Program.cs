using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = { 1, 2, 3, 4, 5, 6, 1};
            //int[] array2 = { 1, 2, 3, 7, 4, 5 };

            //bool result1 = ContainsDuplicates(array1);
            //Console.WriteLine("Array1 contains duplicates is {0}",result1);

            //bool result2 = ContainsDuplicates(array2);
            //Console.WriteLine("Array2 contains duplicates is {0}", result2);

            string foo = "Notebook";
            GetOddChars(foo);
            Console.WriteLine("----------------------------------------------------------------");
            GetOddChars1(foo);
        }
        
        //List solution
        public static bool ContainsDuplicates(params int[] x)
        {
            //Dictionary<int, int> d = new Dictionary<int, int>();
            List<int> d = new List<int>();
            foreach (int i in x)
            {
                if (d.Exists(_ => _ == i))
                    return true;
                else
                    d.Add(i);
            }
            return false;
        }

        static void GetOddChars(string myString)
        {
            Stopwatch s = new Stopwatch();

            s.Start();
            char[] myArr = myString.ToCharArray();

            Console.WriteLine("{0}, {1}, {2}", myArr[0].ToString(), myArr[2].ToString(), myArr[4].ToString());

            s.Stop();
            Console.WriteLine("Time elapsed = {0}", s.Elapsed);

        }

        static void GetOddChars1(string myString)
        {
            Stopwatch s = new Stopwatch();

            s.Start();

            Console.WriteLine("{0}, {1}, {2}", myString[0], myString[2], myString[4]);

            s.Stop();
            Console.WriteLine("Time elapsed = {0}", s.Elapsed);

        }
    }
}
