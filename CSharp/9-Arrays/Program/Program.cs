using System;
using System.Linq;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Arrays Definiton 1, with new operator");
            Console.WriteLine();

            string[] arr = new string[5];
            arr[0] = "Hello";
            arr[1] = ",";
            arr[2] = " ";
            arr[3] = "World";
            arr[4] = "!";

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine("Arrays Definiton 2, initialize array");
            Console.WriteLine();

            string[] arr2 = { "Kedi", "Kopek", "Kus" };

            foreach (var el2 in arr2)
            {
                Console.WriteLine(el2);
            }

            Console.WriteLine();
            Console.WriteLine("Arrays Definiton 3, list to array");
            Console.WriteLine();

            string[] arr3;
            arr3 = new string[3];

            List<string> list = new List<string>();
            list.Add("Mommy Shark");
            list.Add("Daddy Shark");
            list.Add("Baby Shark");

            arr3 = list.ToArray();

            foreach (var el3 in arr3)
            {
                Console.WriteLine(el3);
            }

            Console.WriteLine();
            Console.WriteLine("Arrays Definiton 4, int num to int array");
            Console.WriteLine();

            int num = 47593;
            int[] arr4 = num.ToString().Select(c => (int)Char.GetNumericValue(c)).ToArray();

            foreach (var el4 in arr4)
            {
                Console.WriteLine(el4);
            }

            Console.WriteLine();
        }
    }
}
