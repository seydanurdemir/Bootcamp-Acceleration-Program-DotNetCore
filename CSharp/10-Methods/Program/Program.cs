using System;

namespace Program
{
    public class MethodOverload
    {
        public virtual void Print(int val)
        {
            Console.WriteLine(val);
        }

        public virtual void Print(char val)
        {
            Console.WriteLine(val);
        }
    }

    public class MethodOverride : MethodOverload
    {
        public override void Print(int val)
        {
            Console.WriteLine("int : " + val);
        }

        public override void Print(char val)
        {
            Console.WriteLine("chr : " + val);
        }
    }

    public class RefOut
    {
        public void Increment(ref int ctr)
        {
            ctr++;
        }

        public bool IsQuarter(out int min)
        {
            min = DateTime.Now.Minute;
            //((min == 15) || (min == 45)) ? { return true; } : { return false; };
            return ((min == 15) || (min == 45)) ? true : false;
        }
    }

    public static class ExtensionMethods
    {
        public static void Print<T>(this T[] arr)
        {
            // System.Collections.IEnumerator enum = arr.GetEnumerator();
            // while ((enum.MoveNext()) && (enum.Current != null))
            //     Console.Write(enum.Current + " ");

            foreach (T el in arr)
            {
                Console.Write(el + " ");
            }
        }

        public static string RemoveWhiteSpaces(this string str)
        {
            return string.Join("", str.Split(" "));
        }
    }

    public class RecursiveMethods
    {
        public static long GCD(long number1, long number2)
        {
            if (number2 == 0)
                return number1;
            else
                return GCD(number2, number1 % number2);
        }

        // // Not Recursive
        // public static long LCM(long number1, long number2)
        // {
        //     return (number1 * number2) / GCD(number1, number2);
        // }

        public static long Factorial(long number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

        public static long Fibonacci(long number)
        {
            if (number <= 1)
                return 1;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Methods");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Method Overload");
            Console.WriteLine();

            MethodOverload obj1 = new MethodOverload();
            int val11 = 1000;
            obj1.Print(val11);
            char val12 = 'x';
            obj1.Print(val12);

            Console.WriteLine();
            Console.WriteLine("Method Override");
            Console.WriteLine();

            MethodOverride obj2 = new MethodOverride();
            int val21 = 1000;
            obj2.Print(val21);
            char val22 = 'x';
            obj2.Print(val22);

            Console.WriteLine();
            Console.WriteLine("Ref");
            Console.WriteLine();

            RefOut obj3 = new RefOut();
            int val = 0;
            obj3.Increment(ref val);
            Console.WriteLine("val : " + val);

            Console.WriteLine();
            Console.WriteLine("Out");
            Console.WriteLine();

            RefOut obj4 = new RefOut();
            Console.WriteLine(obj4.IsQuarter(out int min) + " : " + min);

            Console.WriteLine();
            Console.WriteLine("Extension Methods");
            Console.WriteLine();

            int[] arr = { 10, 15, 20, 25, 30 };
            // Static Method Usage
            ExtensionMethods.Print<int>(arr);
            Console.WriteLine();
            // Extension Method Usage
            arr.Print<int>();
            Console.WriteLine();

            Console.WriteLine();
            string snt = "how are you doing today";
            Console.WriteLine(snt.RemoveWhiteSpaces());

            Console.WriteLine();
            Console.WriteLine("Recursive Methods");
            Console.WriteLine();

            // int num = 98765;
            // string str = num.ToString();
            // char[] chr = str.ToCharArray();

            int number = 5;
            int number1 = 24;
            int number2 = 16;
            Console.WriteLine("GCD ({0},{1}) : {2}", number1, number2, RecursiveMethods.GCD(number1, number2));
            //Console.WriteLine("LCM ({0},{1}) : {2}", number1, number2, RecursiveMethods.LCM(number1, number2)); // Not Recursive
            Console.WriteLine("Factorial ({0}) : {1}", number, RecursiveMethods.Factorial(number));
            Console.WriteLine("Fibonacci ({0}) : {1}", number, RecursiveMethods.Fibonacci(number));

            Console.WriteLine();
        }
    }
}
