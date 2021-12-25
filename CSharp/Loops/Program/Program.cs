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
                Console.WriteLine("Bir sayi giriniz : ");
                int sayi = int.Parse(Console.ReadLine());

                int tekToplam = 0;
                int ciftToplam = 0;

                for (int i = 1; i <= sayi; i++)
                {
                    if (i % 2 == 1)
                    {
                        tekToplam += i;
                    }
                    else
                    {
                        ciftToplam += i;
                    }
                }

                Console.WriteLine("1 ile " + sayi + " arasindaki tek sayilarin toplami : " + tekToplam);
                Console.WriteLine("1 ile " + sayi + " arasindaki cift sayilarin toplami : " + ciftToplam);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculated");
            }

        }
    }
}
