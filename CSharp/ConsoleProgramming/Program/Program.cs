using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Isminizi Giriniz : ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyisminizi Giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname + " !");
        }
    }
}
