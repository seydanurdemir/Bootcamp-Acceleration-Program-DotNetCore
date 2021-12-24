using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter number b : ");
                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine("Try : Result is " + c + ".");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch :  Error. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally : Completed.");
            }
        }
    }
}
