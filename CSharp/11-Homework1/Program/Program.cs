using System;

namespace Program
{
    public class Homework1
    {
        public static void Part1()
        {
            Console.WriteLine("Please enter a length : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a number : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] % 2) == 0)
                    Console.WriteLine(arr[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Part 1");
            Console.WriteLine();

            Homework1.Part1();

            Console.WriteLine();
        }
    }
}
