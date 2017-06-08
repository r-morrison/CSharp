using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdArray
{
    class Program
    {
        /* Write a function that takes as input two integer arrays of length len, input and index, 
         * and generates a third array, result, such that:
         result[i] = product of everything in input except input[index[i]] 
         Specifically:
         void everythingExcept(int len,                // in parameters
                               int *input, int *index,
                               int *result             // out parameter
                              );
         For instance, if the function is called with len=4, input={2,3,4,5}, and index={1,3,2,0}, then result will be set to {40,24,30,60}.

         IMPORTANT: Your algorithm must run in linear time.

        If you would like to implement the solution in C#, consider the following signature:
        public int[] everythingExcept(int[] input, int[] index);
       */
        static void Main(string[] args)
        {
            int[] inputArr = { 2, 3, 4, 5 };
            int[] indexArr = { 1, 3, 2, 0 };
            int[] prodArray = everythingExcept(inputArr, indexArr);

            foreach(int i in prodArray)
            {
                Console.WriteLine(i);
            }
        }

        public static void multArray(int[] inputArr)
        {
            for (int i = inputArr.Length - 2; i >= 0; i--)
            {
                inputArr[i] *= inputArr[i + 1];
            }

        }
        public static int[] everythingExcept(int[] input, int[] index)
        {
            int[] retArray= new int[4];
            int prod = 1;

            foreach (int i in index)
            {
                foreach (int j in input)
                {
                    prod *= i;
                    retArray[i] = prod;
                }
            }

            return retArray;

        }

    }
}
