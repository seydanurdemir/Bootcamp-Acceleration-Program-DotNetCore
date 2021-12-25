using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                Console.WriteLine();

                Console.WriteLine("For\n");

                Console.Write("Bir sayi giriniz : ");
                int sayi = int.Parse(Console.ReadLine());

                Console.WriteLine();

                int tekToplam = 0;

                for (int i = 1; i <= sayi; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                        tekToplam += i;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("1 ile " + sayi + " arasindaki tek sayilarin toplami : " + tekToplam);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nCalculated\n");
            }

        }
    }
}
