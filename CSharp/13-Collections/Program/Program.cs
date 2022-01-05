using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Collections");
            Console.WriteLine();

            Console.WriteLine("Generic List");
            Console.WriteLine();

            List<string> daysList = new List<string>();
            daysList.Add("Monday");
            daysList.Add("Tuesday");
            daysList.Add("Wednesday");
            daysList.Add("Thursday");
            daysList.Add("Friday");
            daysList.Add("Saturday");
            daysList.Add("Sunday");

            Console.WriteLine("Count : " + daysList.Count);
            Console.WriteLine();

            Console.WriteLine("Foreach");
            Console.WriteLine();

            foreach (var day in daysList)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("List.Foreach");
            Console.WriteLine();

            daysList.ForEach(day => Console.WriteLine(day));
            Console.WriteLine();

            Console.WriteLine("Remove Range (5,2)");
            Console.WriteLine();

            daysList.RemoveRange(5, 2);
            daysList.ForEach(day => Console.WriteLine(day));
            Console.WriteLine();

            Console.WriteLine("Remove At (2)");
            Console.WriteLine();

            daysList.RemoveAt(2);
            daysList.ForEach(day => Console.WriteLine(day));
            Console.WriteLine();

            Console.WriteLine("Remove Monday");
            Console.WriteLine();

            daysList.Remove("Monday");
            daysList.ForEach(day => Console.WriteLine(day));
            Console.WriteLine();

            Console.WriteLine("Contains Friday" + daysList.Contains("Friday"));
            Console.WriteLine();

            Console.WriteLine("Sort");
            Console.WriteLine();

            daysList.Sort();
            daysList.ForEach(day => Console.WriteLine(day));
            Console.WriteLine();

            Console.WriteLine("BinarySearch Thursday");
            Console.WriteLine();

            Console.WriteLine(daysList.BinarySearch("Tuesday"));
            Console.WriteLine();

            Console.WriteLine("Array to List");
            Console.WriteLine();

            string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };
            List<string> seasonsList = new List<string>(seasons);
            seasonsList.ForEach(season => Console.WriteLine(season));
            Console.WriteLine();

            Console.WriteLine("Clear");
            Console.WriteLine();

            seasonsList.Clear();
            seasonsList.ForEach(season => Console.WriteLine(season));
            seasonsList = new List<string>(seasons);
            seasonsList.ForEach(season => Console.WriteLine(season));
            Console.WriteLine();

            Console.WriteLine("Remove All");
            Console.WriteLine();

            seasonsList.RemoveAll(el => (el != null));
            seasonsList.ForEach(season => Console.WriteLine(season));
            seasonsList = new List<string>(seasons);
            seasonsList.ForEach(season => Console.WriteLine(season));
            Console.WriteLine();

            Console.WriteLine("Convert All");
            Console.WriteLine();

            int[] nums = { 1, 2, 4, 8 };
            List<int> intList = new List<int>(nums);
            intList.ForEach(el => Console.WriteLine("{0,-5} {1,-15}", el, el.GetType()));
            Console.WriteLine();

            List<string> stringList = new List<string>();
            stringList = intList.ConvertAll(new Converter<int, string>(Convert.ToString));
            stringList.ForEach(el => Console.WriteLine("{0,-5} {1,-15}", el, el.GetType()));
            Console.WriteLine();

            Console.WriteLine("ArrayList");
            Console.WriteLine();

            ArrayList arrList = new ArrayList();
            arrList.Add("Seyda Nur");
            arrList.Add("DEMIR");
            arrList.Add(true);
            arrList.Add('K');
            arrList.Add(27.50);
            arrList.Add(1994);

            Console.WriteLine("Count : " + arrList.Count);
            Console.WriteLine();

            Console.WriteLine("Foreach");
            Console.WriteLine();

            foreach (var el in arrList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Element Types");
            Console.WriteLine();

            foreach (var el in arrList)
            {
                Console.WriteLine("{0,-20} {1,-20}", el, el.GetType());
            }
            Console.WriteLine();

            Console.WriteLine("Clear");
            Console.WriteLine();

            arrList.Clear();
            foreach (var el in arrList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Add Range");
            Console.WriteLine();

            int[] numbers = { 25, 0, 100, 50, 75 };
            arrList.AddRange(numbers);
            foreach (var el in arrList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Sort");
            Console.WriteLine();

            arrList.Sort();
            foreach (var el in arrList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Reverse");
            Console.WriteLine();

            arrList.Reverse();
            foreach (var el in arrList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Dictionary");
            Console.WriteLine();

            Dictionary<int, string> dictList = new Dictionary<int, string>();
            dictList.Add(191001, "Ayse");
            dictList.Add(191002, "Fatma");
            dictList.Add(191003, "Hayriye");
            dictList.Add(191004, "Fasulye");

            Console.WriteLine("Count : " + dictList.Count);
            Console.WriteLine();

            Console.WriteLine("Foreach");
            Console.WriteLine();

            foreach (var el in dictList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            Console.WriteLine("Foreach (Key : Value)");
            Console.WriteLine();

            foreach (var el in dictList)
            {
                Console.WriteLine(el.Key + " : " + el.Value);
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
