using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    public class Homework2
    {
        public static bool isPrime(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void Part1()
        {
            int size = 20;
            ArrayList primeList = new ArrayList();
            ArrayList nonprimeList = new ArrayList();

            Console.WriteLine("Taking " + size + " Elements");
            Console.WriteLine();

            int el = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write((i + 1) + ". Element : ");
                el = int.Parse(Console.ReadLine());
                if (isPrime(el))
                {
                    primeList.Add(el);
                }
                else
                {
                    nonprimeList.Add(el);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sorting & Reversing Lists");
            Console.WriteLine();

            primeList.Sort();
            primeList.Reverse();

            nonprimeList.Sort();
            nonprimeList.Reverse();

            Console.WriteLine("Prime List");
            Console.WriteLine();

            foreach (var item in primeList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Count : " + primeList.Count);
            Console.WriteLine();

            int primeSum = 0;
            foreach (var item in primeList)
            {
                primeSum += (int)item;
            }

            Console.WriteLine("Average : " + ((primeList.Count != 0) ? (primeSum / primeList.Count) : 0));
            Console.WriteLine();

            Console.WriteLine("Non-Prime List");
            Console.WriteLine();

            foreach (var item in nonprimeList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Count : " + nonprimeList.Count);
            Console.WriteLine();

            int nonprimeSum = 0;
            foreach (var item in nonprimeList)
            {
                nonprimeSum += (int)item;
            }

            Console.WriteLine("Average : " + ((nonprimeList.Count != 0) ? (nonprimeSum / nonprimeList.Count) : 0));
            Console.WriteLine();
        }

        public static void Part2()
        {
        }

        public static void Part3()
        {
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

            Homework2.Part1();

            Console.WriteLine();
            Console.WriteLine("Part 2 --------------------");
            Console.WriteLine();

            Homework2.Part2();

            Console.WriteLine();
            Console.WriteLine("Part 3 --------------------");
            Console.WriteLine();

            Homework2.Part3();

            Console.WriteLine();
        }
    }
}
