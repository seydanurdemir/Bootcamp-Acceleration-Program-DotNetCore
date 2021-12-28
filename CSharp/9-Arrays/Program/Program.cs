using System;
using System.Linq;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Print<T>(string str, T[] arr)
        {
            Console.Write(str + " : ");
            foreach (T el in arr)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();
        }

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
            Console.WriteLine("Array Class Methods");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1 AsReadOnly");

            Console.WriteLine();
            Console.WriteLine("2 BinarySearch");

            Console.WriteLine();
            Console.WriteLine("3 Clear");
            int[] nums3 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums3", nums3);
            Array.Clear(nums3, 2, 3);
            Print<int>("nums3", nums3);

            Console.WriteLine();
            Console.WriteLine("4 Clone");
            int[] nums4 = (int[])nums3.Clone();
            Print<int>("nums4", nums4);

            Console.WriteLine();
            Console.WriteLine("5 ConstrainedCopy");
            int[] nums5 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums4", nums4);
            Print<int>("nums5", nums5);
            Array.ConstrainedCopy(nums4, 2, nums5, 6, 3);
            Print<int>("nums5", nums5);

            Console.WriteLine();
            Console.WriteLine("6 ConvertAll");
            char[] chars6 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            Print<char>("chars6", chars6);
            int[] nums6 = new int[chars6.Length];
            nums6 = Array.ConvertAll<char, int>(chars6, new Converter<char, int>(Convert.ToInt32));
            Print<int>("nums6", nums6);

            Console.WriteLine();
            Console.WriteLine("7 Copy");
            int[] nums7 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums6", nums6);
            Print<int>("nums7", nums7);
            Array.Copy(nums6, 0, nums7, 7, 3);
            Print<int>("nums7", nums7);

            Console.WriteLine();
            Console.WriteLine("8 CopyTo");
            Print<int>("nums7", nums7);
            int[] nums8 = new int[nums7.Length + 5];
            nums7.CopyTo(nums8, 3);
            Print<int>("nums8", nums8);

            Console.WriteLine();
            Console.WriteLine("9 Create Instance");
            int[] nums9 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums9);

            Console.WriteLine();
            Console.WriteLine("10 Empty");
            int[] nums10 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums10);

            Console.WriteLine();
            Console.WriteLine("11 Exists");
            int[] nums11 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums11);

            Console.WriteLine();
            Console.WriteLine("12 Fill");
            int[] nums12 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums12);

            Console.WriteLine();
            Console.WriteLine("13 Find");
            int[] nums13 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums13);

            Console.WriteLine();
            Console.WriteLine("14 FindAll");
            int[] nums14 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums14);

            Console.WriteLine();
            Console.WriteLine("15 FindIndex");
            int[] nums15 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums15);

            Console.WriteLine();
            Console.WriteLine("16 FindLast");
            int[] nums16 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums16);

            Console.WriteLine();
            Console.WriteLine("17 FindLastIndex");
            int[] nums17 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums17);

            Console.WriteLine();
            Console.WriteLine("18 ForEach");
            int[] nums18 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums18);

            Console.WriteLine();
            Console.WriteLine("19 GetEnumerator");
            int[] nums19 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums19);

            Console.WriteLine();
            Console.WriteLine("20 GetLength");
            int[] nums20 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums20);

            Console.WriteLine();
            Console.WriteLine("21 GetLongLength");
            int[] nums21 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums21);

            Console.WriteLine();
            Console.WriteLine("22 GetLowerBound");
            int[] nums22 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums22);

            Console.WriteLine();
            Console.WriteLine("23 GetUpperBound");
            int[] nums23 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums23);

            Console.WriteLine();
            Console.WriteLine("24 GetValue");
            int[] nums24 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums24);

            Console.WriteLine();
            Console.WriteLine("25 IndexOf");
            int[] nums25 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums25);

            Console.WriteLine();
            Console.WriteLine("26 Initialize");
            int[] nums26 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums26);

            Console.WriteLine();
            Console.WriteLine("27 LastIndexOf");
            int[] nums27 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums27);

            Console.WriteLine();
            Console.WriteLine("28 Resize");
            int[] nums28 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums28);

            Console.WriteLine();
            Console.WriteLine("29 Reverse");
            int[] nums29 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums29);

            Console.WriteLine();
            Console.WriteLine("30 SetValue");
            int[] nums30 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums30);

            Console.WriteLine();
            Console.WriteLine("31 Sort");
            int[] nums31 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums31);

            Console.WriteLine();
            Console.WriteLine("32 TrueForAll");
            int[] nums32 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("", nums32);

            Console.WriteLine();
        }
    }
}
