using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            List<int> yourList = new List<int>();
            List<int> mergedList = new List<int>();

            myList.Add(3);
            myList.Add(4);
            myList.Add(6);
            myList.Add(10);
            myList.Add(11);
            myList.Add(15);

            yourList.Add(1);
            yourList.Add(5);
            yourList.Add(8);
            yourList.Add(12);
            yourList.Add(14);
            yourList.Add(19);

            foreach (var item in yourList)
            {
                myList.Add(item);
            }

            myList.Sort();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
