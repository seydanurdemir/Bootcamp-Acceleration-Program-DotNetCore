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
            int size = 20;
            ArrayList numberList = new ArrayList();

            Console.WriteLine("Taking " + size + " Elements");
            Console.WriteLine();

            int el = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write((i + 1) + ". Element : ");
                el = int.Parse(Console.ReadLine());
                numberList.Add(el);
            }
            Console.WriteLine();

            Console.WriteLine("Print List");
            Console.WriteLine();

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Sorting & Reversing List");
            Console.WriteLine();

            int min1, min2, min3, minAvg;
            numberList.Sort();
            min1 = (int)numberList[0];
            min2 = (int)numberList[1];
            min3 = (int)numberList[2];
            minAvg = ((min1 + min2 + min3) / 3);

            Console.WriteLine("Minimum 1 : " + min1);
            Console.WriteLine("Minimum 2 : " + min2);
            Console.WriteLine("Minimum 3 : " + min3);
            Console.WriteLine();

            Console.WriteLine("Minimum Average : " + minAvg);
            Console.WriteLine();

            int max1, max2, max3, maxAvg;
            numberList.Reverse();
            max1 = (int)numberList[0];
            max2 = (int)numberList[1];
            max3 = (int)numberList[2];
            maxAvg = ((max1 + max2 + max3) / 3);

            Console.WriteLine("Maximum 1 : " + max1);
            Console.WriteLine("Maximum 2 : " + max2);
            Console.WriteLine("Maximum 3 : " + max3);
            Console.WriteLine();

            Console.WriteLine("Maximum Average : " + maxAvg);
            Console.WriteLine();

            int sumAvg = minAvg + maxAvg;

            Console.WriteLine("Sum of Averages : " + sumAvg);
            Console.WriteLine();
        }

        public static bool isVowel(char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

            if (Array.IndexOf(vowels, letter) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Part3()
        {
            Console.WriteLine("Taking Sentences");
            Console.WriteLine();

            string sentences = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Create Vowels List");
            Console.WriteLine();

            char[] letters = sentences.ToCharArray();
            List<char> vowels = new List<char>(letters);
            vowels.RemoveAll(el => (!isVowel(el)));

            Console.WriteLine("Print List");
            Console.WriteLine();

            vowels.ForEach(el => Console.WriteLine(el));
            Console.WriteLine();

            Console.WriteLine("Sort List");
            Console.WriteLine();

            vowels.Sort();

            Console.WriteLine("Print Sorted List");
            Console.WriteLine();

            vowels.ForEach(el => Console.WriteLine(el));
            Console.WriteLine();

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
