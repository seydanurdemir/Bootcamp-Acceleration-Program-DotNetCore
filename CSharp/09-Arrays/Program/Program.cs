using System;
using System.Linq;
using System.Collections.Generic;

// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=net-6.0

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
            Console.WriteLine("4 Clone ***");
            Print<int>("nums3", nums3);
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
            char[] chrs6 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            Print<char>("chrs6", chrs6);
            int[] nums6 = new int[chrs6.Length];
            nums6 = Array.ConvertAll<char, int>(chrs6, new Converter<char, int>(Convert.ToInt32));
            Print<int>("nums6", nums6);

            Console.WriteLine();
            Console.WriteLine("7 Copy");
            int[] nums7 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums6", nums6);
            Print<int>("nums7", nums7);
            Array.Copy(nums6, 0, nums7, 7, 3);
            Print<int>("nums7", nums7);

            Console.WriteLine();
            Console.WriteLine("8 CopyTo ***");
            Print<int>("nums7", nums7);
            int[] nums8 = new int[nums7.Length + 5];
            nums7.CopyTo(nums8, 3);
            Print<int>("nums8", nums8);

            Console.WriteLine();
            Console.WriteLine("9 Create Instance");
            Array nums9 = Array.CreateInstance(typeof(int), 10);
            int i9 = 0;
            for (i9 = 0; i9 < 10; i9++)
            {
                nums9.SetValue(i9, i9);
            }
            System.Collections.IEnumerator enum9 = nums9.GetEnumerator();
            Console.Write("nums9 : ");
            while ((enum9.MoveNext()) && (enum9.Current != null))
            {
                Console.Write(enum9.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("10 Empty");
            int[] nums10 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums10", nums10);
            nums10 = Array.Empty<int>();
            Print<int>("nums10", nums10);

            Console.WriteLine();
            Console.WriteLine("11 Exists");
            int[] nums11 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums11", nums11);
            Console.WriteLine("Does 7 exist in the array?");
            bool res11 = Array.Exists<int>(nums11, el => (el == 7));
            Console.WriteLine("res11 : " + res11);

            Console.WriteLine();
            Console.WriteLine("12 Fill");
            int[] nums12 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums12", nums12);
            Array.Fill<int>(nums12, 1, 7, 3);
            Print<int>("nums12", nums12);

            Console.WriteLine();
            Console.WriteLine("13 Find");
            int[] nums13 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Print<int>("nums13", nums13);
            int el13 = Array.Find<int>(nums13, el => ((el != 0) && ((el % 3) == 0)));
            Console.WriteLine("el13 : " + el13);

            Console.WriteLine();
            Console.WriteLine("14 FindAll");
            Print<int>("nums13", nums13);
            int[] nums14 = Array.FindAll<int>(nums13, el => ((el != 0) && ((el % 3) == 0)));
            Print<int>("nums14", nums14);

            Console.WriteLine();
            Console.WriteLine("15 FindIndex");
            Print<int>("nums13", nums13);
            int i15 = Array.FindIndex<int>(nums13, el => ((el != 0) && ((el % 3) == 0)));
            Console.WriteLine("i15 : " + i15);

            Console.WriteLine();
            Console.WriteLine("16 FindLast");
            Print<int>("nums13", nums13);
            int el16 = Array.FindLast<int>(nums13, el => ((el != 0) && ((el % 3) == 0)));
            Console.WriteLine("el16 : " + el16);

            Console.WriteLine();
            Console.WriteLine("17 FindLastIndex");
            Print<int>("nums13", nums13);
            int i17 = Array.FindLastIndex<int>(nums13, el => ((el != 0) && ((el % 3) == 0)));
            Console.WriteLine("i17 : " + i17);

            Console.WriteLine();
            Console.WriteLine("18 ForEach");
            int[] nums18 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums18", nums18);
            Console.Write("el18 : ");
            Array.ForEach<int>(nums18, el => { if ((el % 3) == 0) Console.Write(el + " "); });
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("19 GetEnumerator ***");
            int[] nums19 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums19", nums19);
            System.Collections.IEnumerator enum19 = nums19.GetEnumerator();
            Console.Write("nums19 : ");
            while ((enum19.MoveNext()) && (enum19.Current != null))
            {
                Console.Write(enum19.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("20 GetLength ***");
            int[] nums20 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums20", nums20);
            Console.WriteLine("len20 : " + nums20.GetLength(0));

            Console.WriteLine();
            Console.WriteLine("21 GetLongLength ***");
            Print<int>("nums20", nums20);
            Console.WriteLine("len21 : " + nums20.GetLongLength(0));

            Console.WriteLine();
            Console.WriteLine("22 GetLowerBound ***");
            Print<int>("nums20", nums20);
            Console.WriteLine("lower22 : " + nums20.GetLowerBound(0));

            Console.WriteLine();
            Console.WriteLine("23 GetUpperBound ***");
            Print<int>("nums20", nums20);
            Console.WriteLine("upper23 : " + nums20.GetUpperBound(0));

            Console.WriteLine();
            Console.WriteLine("24 GetValue ***");
            Print<int>("nums20", nums20);
            Console.WriteLine("value24 : " + nums20.GetValue(5));

            Console.WriteLine();
            Console.WriteLine("25 IndexOf");
            int[] nums25 = { 0, 1, 2, 0, 1, 2, 0, 1, 2, 0 };
            Print<int>("nums25", nums25);
            Console.WriteLine("i25 : " + Array.IndexOf<int>(nums25, 0, 4, 6));

            Console.WriteLine();
            Console.WriteLine("26 Initialize ***");
            Array nums26 = Array.CreateInstance(typeof(int), 10);
            nums26.Initialize();
            System.Collections.IEnumerator enum26 = nums26.GetEnumerator();
            Console.Write("nums26 : ");
            while ((enum26.MoveNext()) && (enum26.Current != null))
            {
                Console.Write(enum26.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("27 LastIndexOf");
            Print<int>("nums25", nums25);
            Console.WriteLine("i27 : " + Array.LastIndexOf<int>(nums25, 0, 9, 5));

            Console.WriteLine();
            Console.WriteLine("28 Resize");
            int[] nums28 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print<int>("nums28", nums28);
            Array.Resize<int>(ref nums28, 5);
            Print<int>("nums28", nums28);

            Console.WriteLine();
            Console.WriteLine("29 Reverse");
            string str29 = "palindrome";
            char[] chrs29 = str29.ToCharArray();
            Print<char>("chrs29", chrs29);
            Array.Reverse<char>(chrs29);
            Print<char>("chrs29", chrs29);

            Console.WriteLine();
            Console.WriteLine("30 SetValue");
            Print<int>("nums20", nums20);
            nums20.SetValue(5000, 5);
            Print<int>("nums20", nums20);

            Console.WriteLine();
            Console.WriteLine("31 Sort");
            int[] nums31 = { 7, 1, 9, 3, 0, 8, 5, 6, 4, 2 };
            Print<int>("nums31", nums31);
            Array.Sort<int>(nums31);
            Print<int>("nums31", nums31);

            Console.WriteLine();
            Console.WriteLine("32 TrueForAll");
            int[] nums32 = new int[10];
            Print<int>("nums32", nums32);
            Console.WriteLine("Are all elements zero in the array?");
            Console.WriteLine(Array.TrueForAll(nums32, el => (el == 0)));
            nums32.SetValue(9, 9);
            Print<int>("nums32", nums32);
            Console.WriteLine("Are all elements zero in the array?");
            Console.WriteLine(Array.TrueForAll(nums32, el => (el == 0)));

            Console.WriteLine();
        }
    }
}
