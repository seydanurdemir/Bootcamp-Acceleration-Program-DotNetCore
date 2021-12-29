using System;

namespace Program
{
    public class Homework1
    {
        public static void Part1()
        {
            Console.WriteLine("Taking Array Size");
            Console.WriteLine();

            Console.Write("n : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine();
            Console.WriteLine("Taking Array Elements");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Printing Even Numbers");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if ((arr[i] % 2) == 0)
                    Console.WriteLine("arr[" + i + "] : " + arr[i]);
            }
        }

        public static void Part2()
        {
            Console.WriteLine("Taking Array Size");
            Console.WriteLine();

            Console.Write("n : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine();
            Console.WriteLine("Taking Target Element");
            Console.WriteLine();

            Console.Write("m : ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Taking Array Elements");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Printing mx Numbers");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == m)
                    Console.WriteLine("arr[" + i + "] : " + arr[i] + " (equals to m)");
                else if ((arr[i] % m) == 0)
                    Console.WriteLine("arr[" + i + "] : " + arr[i]);
            }
        }

        public static void Part3()
        {
            Console.WriteLine("Taking Array Size");
            Console.WriteLine();

            Console.Write("n : ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];

            Console.WriteLine();
            Console.WriteLine("Taking Array Elements");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] : ");
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Printing Strings Backward");
            Console.WriteLine();

            for (int i = (n - 1); i >= 0; i--)
            {
                Console.WriteLine("arr[" + i + "] : " + arr[i]);
            }
        }

        public static void Part4()
        {
            Console.WriteLine("Taking Sentences");
            Console.WriteLine();

            Console.WriteLine("(Please do not use punctuations!)");
            Console.Write("Sentences : ");
            string str = Console.ReadLine();

            string[] words = str.Split(" ");
            int word = words.Length;
            char[] letters = string.Join("", str.Split(" ")).ToCharArray();
            int letter = letters.Length;

            Console.WriteLine();
            Console.WriteLine("Printing Word Count");
            Console.WriteLine();

            Console.WriteLine("Word Count : " + word);

            Console.WriteLine();
            Console.WriteLine("Printing Letter Count");
            Console.WriteLine();

            Console.WriteLine("Letter Count : " + letter);
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
            Console.WriteLine("Part 1 --------------------");
            Console.WriteLine();

            Homework1.Part1();

            Console.WriteLine();
            Console.WriteLine("Part 2 --------------------");
            Console.WriteLine();

            Homework1.Part2();

            Console.WriteLine();
            Console.WriteLine("Part 3 --------------------");
            Console.WriteLine();

            Homework1.Part3();

            Console.WriteLine();
            Console.WriteLine("Part 4 --------------------");
            Console.WriteLine();

            Homework1.Part4();

            Console.WriteLine();
        }
    }
}
