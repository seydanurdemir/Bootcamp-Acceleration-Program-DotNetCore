using System;

// https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
// https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=net-6.0
// https://docs.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0

namespace Program
{
    class Program
    {
        public static double AngRadDeg(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            return angle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("String Methods");
            Console.WriteLine();

            string str1 = "aaa";
            string str2 = "bbb";
            string str3 = "aaa bbb ccc";
            string str4 = "ccc";
            decimal dec = 20.4m;
            string str5 = "the quick brown fox";
            char[] chars1 = { 'a', 'e', 'i', 'o', 'u' };
            string str6 = "ddd ";
            string str7 = "";
            string str8 = null;
            string str9 = " ";
            string str10 = new String(new char[] { '\u0063', '\u0301', '\u0327', '\u00BE' });
            string str11 = "docment size";
            string str12 = "CaMeL";
            string str13 = "... how, do you, feel ?! ...";
            char[] chars2 = { '.', ',', '?', '!', ' ' };

            Console.WriteLine(" 1. Compare ({0}, {1}) : {2}", str1, str2, String.Compare(str1, str2));
            Console.WriteLine(" 3. CompareTo ({0}, {1}) : {2} ***", str1, str2, str1.CompareTo(str2));
            Console.WriteLine(" 4. Concat ({0}, {1}) : {2}", str1, str2, String.Concat(str1, str2));
            Console.WriteLine(" 5. Contains ({0}, {1}) : {2} ***", str3, str1, str3.Contains(str1));
            Console.WriteLine(" 9. EndsWith ({0}, {1}) : {2} ***", str3, str4, str3.EndsWith(str4));
            Console.WriteLine("12. Format ({0}) : {1}", dec, String.Format("{0}°C", dec));
            Console.WriteLine("17. IndexOf ({0}, {1}) : {2} ***", str3, str4, str3.IndexOf(str4));
            Console.WriteLine("18. IndexOfAny ({0}, a-e-i-o-u) : {1} ***", str5, str5.IndexOfAny(chars1));
            Console.WriteLine("19. Insert ({0}, {1}) : {2} ***", str3, str6, str3.Insert(4, str6));
            Console.WriteLine("23. IsNullOrEmpty ({0}, \"\", null) : {1} {2} {3}", str1, String.IsNullOrEmpty(str1), String.IsNullOrEmpty(str7), String.IsNullOrEmpty(str8));
            Console.WriteLine("24. IsNullOrWhiteSpace ({0}, \" \", null) : {1} {2} {3}", str1, String.IsNullOrWhiteSpace(str1), String.IsNullOrWhiteSpace(str9), String.IsNullOrWhiteSpace(str8));
            Console.WriteLine("25. Join (\" and \", a-e-i-o-u) : {0}", String.Join(" and ", chars1));
            Console.WriteLine("26. LastIndexOf ({0}, {1}) : {2} ***", str3, str4, str3.LastIndexOf(str4));
            Console.WriteLine("27. LastIndexOfAny ({0}, a-e-i-o-u) : {1} ***", str5, str5.LastIndexOfAny(chars1));
            Console.WriteLine("29. PadLeft ({0}) : \"{1}\" ***", str1, str1.PadLeft(10));
            Console.WriteLine("30. PadRight ({0}) : \"{1}\" ***", str1, str1.PadRight(10));
            Console.WriteLine("31. Remove ({0}) : {1} ***", str3, str3.Remove(4, 4));
            Console.WriteLine("32. Replace ({0}) : {1} ***", str11, str11.Replace("docment", "document"));
            Console.WriteLine("34. Split ({0}) : {1} ***", str5, str5.Split(' ')[0]);
            Console.WriteLine("35. StartsWith ({0}, {1}) : {2} ***", str3, str1, str3.StartsWith(str1));
            Console.WriteLine("36. Substring ({0}) : {1} ***", str3, str3.Substring(4, 4));
            Console.WriteLine("37. ToCharArray ({0}) : {1} ***", str1, str1.ToCharArray()[0]);
            Console.WriteLine("38. ToLower ({0}) : {1} ***", str2, str12.ToLower());
            Console.WriteLine("42. ToUpper ({0}) : {1} ***", str2, str12.ToUpper());
            Console.WriteLine("44. Trim ({0}) : {1} ***", str13, str13.Trim(chars2));

            Console.WriteLine();
            Console.WriteLine("DateTime Methods");
            Console.WriteLine();

            Console.WriteLine("{0,-20}   {1,0}", "Member", "Result");
            Console.WriteLine("{0,-20}   {1,0}", "------", "------");

            Console.WriteLine("{0,-20} : {1,0}", "Now", DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "Date", DateTime.Now.Date);
            Console.WriteLine("{0,-20} : {1,0}", "ToLongDateString", DateTime.Now.ToLongDateString());
            Console.WriteLine("{0,-20} : {1,0}", "ToShortDateString", DateTime.Now.ToShortDateString());
            Console.WriteLine("{0,-20} : {1,0}", "ToLongTimeString", DateTime.Now.ToLongTimeString());
            Console.WriteLine("{0,-20} : {1,0}", "ToShortTimeString", DateTime.Now.ToShortTimeString());
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "DayOfWeek", DateTime.Now.DayOfWeek);
            Console.WriteLine("{0,-20} : {1,0}", "DayOfYear", DateTime.Now.DayOfYear);
            Console.WriteLine("{0,-20} : {1,0}", "IsLeapYear", DateTime.IsLeapYear(1994));
            Console.WriteLine("{0,-20} : {1,0}", "DaysInMonth", DateTime.DaysInMonth(1994, 2));
            Console.WriteLine("{0,-20} : {1,0}", "IsLeapYear", DateTime.IsLeapYear(1996));
            Console.WriteLine("{0,-20} : {1,0}", "DaysInMonth", DateTime.DaysInMonth(1996, 2));
            Console.WriteLine("{0,-20} : {1,0}", "IsDaylightSavingTime", DateTime.Now.IsDaylightSavingTime());
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "Year", DateTime.Now.Year);
            Console.WriteLine("{0,-20} : {1,0}", "Month", DateTime.Now.Month);
            Console.WriteLine("{0,-20} : {1,0}", "Day", DateTime.Now.Day);
            Console.WriteLine("{0,-20} : {1,0}", "Hour", DateTime.Now.Hour);
            Console.WriteLine("{0,-20} : {1,0}", "Minute", DateTime.Now.Minute);
            Console.WriteLine("{0,-20} : {1,0}", "Second", DateTime.Now.Second);
            Console.WriteLine("{0,-20} : {1,0}", "Millisecond", DateTime.Now.Millisecond);
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "Add", DateTime.Now.Add(new TimeSpan(10, 0, 0, 0)));
            Console.WriteLine("{0,-20} : {1,0}", "Subtract", DateTime.Now.Subtract(DateTime.Now.Add(new TimeSpan(10, 0, 0, 0))));
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "AddYear", DateTime.Now.AddYears(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddMonth", DateTime.Now.AddMonths(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddDay", DateTime.Now.AddDays(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddHour", DateTime.Now.AddHours(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddMinute", DateTime.Now.AddMinutes(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddSecond", DateTime.Now.AddSeconds(1));
            Console.WriteLine("{0,-20} : {1,0}", "AddMillisecond", DateTime.Now.AddMilliseconds(1));
            Console.WriteLine();

            Console.WriteLine("{0,-20} : {1,0}", "ToString", DateTime.Now.ToString());
            Console.WriteLine();

            foreach (string format in DateTime.Now.GetDateTimeFormats())
            {
                Console.WriteLine(format);
            }

            Console.WriteLine();
            Console.WriteLine("Math Methods");
            Console.WriteLine();

            Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-10}", "Method", "Value1", "Value2", "Result");
            Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-10}", "------------", "----------", "----------", "----------");
            Console.WriteLine();

            decimal dec1 = -10.25m;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Abs", "", dec1, Math.Abs(dec1));
            Console.WriteLine();

            decimal dec2 = 10.50m;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Ceiling", "", dec2, Math.Ceiling(dec2));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Floor", "", dec2, Math.Floor(dec2));

            decimal dec3 = 10.50m;
            decimal dec4 = 10.51m;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Round", "", dec3, Math.Round(dec3));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Round", "", dec4, Math.Round(dec4));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Truncate", "", dec2, Math.Truncate(dec2));
            Console.WriteLine();

            int int1 = Int32.MaxValue;
            int int2 = Int32.MaxValue;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "BigMul", int1, int2, Math.BigMul(int1, int2));
            int int3 = 3;
            int int4 = 4;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Pow", int3, int4, Math.Pow(int3, int4));
            int int5 = 81;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Sqrt", "", int5, Math.Sqrt(int5));
            Console.WriteLine();

            double dbl1 = 10000;
            int int6 = 10;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Log", dbl1, int6, Math.Log(dbl1, int6));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Log10", "", dbl1, Math.Log10(dbl1));
            double dbl2 = 128;
            int int7 = 2;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Log", dbl2, int7, Math.Log(dbl2, int7));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Log2", "", dbl2, Math.Log2(dbl2));
            Console.WriteLine();

            int int8 = 20;
            int int9 = -25;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Max", int8, int9, Math.Max(int8, int9));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "Min", int8, int9, Math.Min(int8, int9));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "MaxMagnitude", int8, int9, Math.MaxMagnitude(int8, int9));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10}", "MinMagnitude", int8, int9, Math.MinMagnitude(int8, int9));
            Console.WriteLine();

            double dbl3 = 0;
            double dbl4 = 30;
            double dbl5 = 45;
            double dbl6 = 60;
            double dbl7 = 90;
            double dbl8 = 180;
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Sin", "", dbl3, Math.Sin(AngRadDeg(dbl3)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Sin", "", dbl4, Math.Sin(AngRadDeg(dbl4)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Sin", "", dbl6, Math.Sin(AngRadDeg(dbl6)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Sin", "", dbl7, Math.Sin(AngRadDeg(dbl7)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Sin", "", dbl8, Math.Sin(AngRadDeg(dbl8)));
            Console.WriteLine();
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Cos", "", dbl3, Math.Cos(AngRadDeg(dbl3)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Cos", "", dbl4, Math.Cos(AngRadDeg(dbl4)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Cos", "", dbl6, Math.Cos(AngRadDeg(dbl6)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Cos", "", dbl7, Math.Cos(AngRadDeg(dbl7)));
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Cos", "", dbl8, Math.Cos(AngRadDeg(dbl8)));
            Console.WriteLine();
            Console.WriteLine("{0,-12} {1,10} {2,10} {3,10:0.00}", "Tan", "", dbl5, Math.Tan(AngRadDeg(dbl5)));

            Console.WriteLine();
        }
    }
}
