using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine("Try" + c);
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
