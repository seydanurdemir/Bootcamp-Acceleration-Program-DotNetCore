using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("For");
            Console.WriteLine();

            Console.WriteLine();

            int i = 0;
            int tekToplam = 0;

            for (i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    tekToplam += i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("1 ile 20 arasindaki tek sayilarin toplami : " + tekToplam);

            Console.WriteLine();
            Console.WriteLine("Continue - Break");
            Console.WriteLine();

            for (i = 1; i <= 20; i++)
            {
                if (i % 5 == 0)
                    continue;
                if (i == 17)
                    break;

                Console.WriteLine(i);
            }

            // int a = 0;
            // for (; a < 10;) { Console.WriteLine(++a); }

            Console.WriteLine();
            Console.WriteLine("Infinite Loop");
            Console.WriteLine();

            //for (; ; ) { }
            Console.WriteLine("for (; ; ) { }");

            Console.WriteLine();
            Console.WriteLine("While - Do While");
            Console.WriteLine();

            int j = 0;
            string str = "Merhaba";

            while ((str[j] != 'a') && (j < str.Length))
            {
                Console.WriteLine(str[j]);
                j++;
            }

            Console.WriteLine();
            Console.WriteLine("Foreach");
            Console.WriteLine();

            int[] arr = { 45, 60, 15, 0, 180, 90, 75 };

            foreach (int k in arr)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();
        }
    }
}
