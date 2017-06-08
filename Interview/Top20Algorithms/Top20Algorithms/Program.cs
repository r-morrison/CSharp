using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top20Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };

            int result = GetMajorityElement(array);
            if (result != -1)
            {
                Console.WriteLine("Majority element is: {0}", result);
            }
            else
            {
                Console.WriteLine("No majority element");
            }
        }

        //Find majority element in an unsorted array
        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority 
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;
            int result = -1;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                    {
                       
                        result = i;
                    }
                }
                else
                    d.Add(i, 1);
            return result;
        }


    }
}
