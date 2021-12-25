using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // if - else if - else
            Console.WriteLine();

            Console.WriteLine("If - Else If - Else\n");

            int h = DateTime.Now.Hour;

            if ((h >= 6) && (h < 12))
            {
                Console.WriteLine("Gunaydin !");
            }
            else if ((h >= 12) && (h < 18))
            {
                Console.WriteLine("Iyi gunler !");
            }
            else
            {
                Console.WriteLine("Iyi aksamlar !");
            }

            // ternary if
            Console.WriteLine();

            Console.WriteLine("Ternary If\n");

            int d = DateTime.Now.Day;

            string s = (d < 15) ? "Ayin ilk yarisi" : (d > 15) ? "Ayin son yarisi" : (d == 15) ? "Ayin tam ortasi" : "Hatali gun verisi";

            Console.WriteLine(s);

            // switch - case - default
            Console.WriteLine();

            Console.WriteLine("Switch - Case - Default\n");

            int m = DateTime.Now.Minute;

            switch (m)
            {
                case 0:
                    Console.WriteLine("Saat basi");
                    break;
                case 15:
                    Console.WriteLine("Ceyrek geciyor");
                    break;
                case 30:
                    Console.WriteLine("Bucuk");
                    break;
                case 45:
                    Console.WriteLine("Ceyrek var");
                    break;
                default:
                    Console.WriteLine("Ara bir saat");
                    break;
            }


        }
    }
}
