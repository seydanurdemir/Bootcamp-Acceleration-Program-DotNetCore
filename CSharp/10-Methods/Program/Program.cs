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
        }
    }
}
