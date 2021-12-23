using System;

namespace VariablesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sbyte var_sbyte = -128; // 1 byte, 8 bits, from -128 to 127
            Console.WriteLine("sbyte : " + var_sbyte);

            byte var_byte = 255; // 1 byte, 8 bits, from 0 to 255
            Console.WriteLine("byte : " + var_byte);

            short var_short = -32768; // 2 bytes, 16 bits, from -32,768 to 32,767
            Console.WriteLine("short : " + var_short);

            ushort var_ushort = 65535; // 2 bytes, 16 bits, from 0 to 65,535
            Console.WriteLine("ushort : " + var_ushort);

            int var_int = -2147483648; // 4 bytes, 32 bits, from -2,147,483,648 to 2,147,483,647
            Console.WriteLine("int : " + var_int);

            uint var_uint = 4294967295; // 4 bytes, 32 bits, from 0 to 4,294,967,295, -u
            Console.WriteLine("uint : " + var_uint);

            long var_long = -9223372036854775808L; // 8 bytes, 64 bits, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, -l
            Console.WriteLine("long : " + var_long);

            ulong var_ulong = 18446744073709551615ul; // 8 bytes, 64 bits, from 0 to 18,446,744,073,709,551,615, -ul
            Console.WriteLine("ulong : " + var_ulong);

            float var_float = -3.402823e38f; // 4 bytes, 32 bits, single-precision, 7 significant digits, from -3.402823e38 to 3.402823e38, -f
            Console.WriteLine("float : " + var_float);

            double var_double = -1.79769313486232e307d; // 8 bytes, 64 bits, double-precision, 15 significant digits, -1.79769313486232e308 to 1.79769313486232e308, -d
            Console.WriteLine("double : " + var_double);

            object var_object = null; // 4 byte addresses, all csharp objects
            Console.WriteLine("object : " + var_object);

            char var_char = '*'; // 2 bytes, 16 bits, unicode characters, any valid character, e.g. a,*, \x0058 (hex), or \u0058 (Unicode)
            Console.WriteLine("char : " + var_char);

            string var_string = "string"; // 4 byte addresses, length up to 2 billion bytes
            Console.WriteLine("string : " + var_string);

            decimal var_decimal = 1000.25m; // 24 bytes, from 28 to 29 significant digits, 128 bits, from (+ or -)1.0 x 10e-28 to 7.9 x 10e28, -m
            Console.WriteLine("decimal : " + var_decimal);

            bool var_bool = true; // 1 byte, 8 bits, true or false
            Console.WriteLine("bool : " + var_bool);

            DateTime var_datetime = DateTime.Now; // 8 bytes, from 00:00:00am 01/01/01 to 11:59:59pm 12/31/9999
            Console.WriteLine("DateTime : " + var_datetime);

            //DateSpan var_datespan = null; // n bytes, from -10675199.02:48:05.4775808 to 10675199.02:48:05.47758076
            //Console.WriteLine("DateSpan : " + var_datespan);

            int int20 = 20;
            string str20 = "20";

            string newstr20 = str20 + int20.ToString();
            Console.WriteLine(newstr20);

            string newnewstr20 = str20 + Convert.ToString(int20);
            Console.WriteLine(newnewstr20);

            int newint20 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(newint20);

            int newnewint20 = int20 + int.Parse(str20);
            Console.WriteLine(newnewint20);
        }
    }
}
