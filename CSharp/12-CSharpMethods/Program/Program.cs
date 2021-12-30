using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("String Methods");
            Console.WriteLine();

            // string str = "how ... do you feel, today?!";
            // Console.WriteLine(str.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", ""));

            //string str = "the quick brown fox jumps over the lazy dog";

            Console.WriteLine();
            Console.WriteLine("Compare");
            Console.WriteLine();

            string str1 = "aaa";
            string str2 = "bbb";
            string str3 = "aaa bbb ccc";
            string str4 = "ccc";
            decimal dec = 20.4m;
            string str5 = "the quick brown fox";
            char[] chars = { 'a', 'e', 'i', 'o', 'u' };
            string str6 = "ddd ";
            string str7 = "";
            string str8 = null;
            string str9 = " ";
            string str10 = new String(new char[] { '\u0063', '\u0301', '\u0327', '\u00BE' });
            string str11 = "docment size";
            Console.WriteLine("1. Compare ({0}, {1}) : {2}", str1, str2, String.Compare(str1, str2));
            Console.WriteLine("3. CompareTo ({0}, {1}) : {2} ***", str1, str2, str1.CompareTo(str2));
            Console.WriteLine("4. Concat ({0}, {1}) : {2}", str1, str2, String.Concat(str1, str2));
            Console.WriteLine("5. Contains ({0}, {1}) : {2} ***", str3, str1, str3.Contains(str1));
            Console.WriteLine("9. EndsWith ({0}, {1}) : {2} ***", str3, str4, str3.EndsWith(str4));
            Console.WriteLine("12. Format ({0}) : {1}", dec, String.Format("{0}°C", dec));
            Console.WriteLine("17. IndexOf ({0}, {1}) : {2} ***", str3, str4, str3.IndexOf(str4));
            Console.WriteLine("18. IndexOfAny ({0}, a-e-i-o-u) : {1} ***", str5, str5.IndexOfAny(chars));
            Console.WriteLine("19. Insert ({0}, {1}) : {2} ***", str3, str6, str3.Insert(4, str6));
            Console.WriteLine("23. IsNullOrEmpty ({0}, \"\", null) : {1} {2} {3}", str1, String.IsNullOrEmpty(str1), String.IsNullOrEmpty(str7), String.IsNullOrEmpty(str8));
            Console.WriteLine("24. IsNullOrWhiteSpace ({0}, \" \", null) : {1} {2} {3}", str1, String.IsNullOrWhiteSpace(str1), String.IsNullOrWhiteSpace(str9), String.IsNullOrWhiteSpace(str8));
            Console.WriteLine("25. Join (\" and \", a-e-i-o-u) : {0}", String.Join(" and ", chars));
            Console.WriteLine("26. LastIndexOf ({0}, {1}) : {2} ***", str3, str4, str3.LastIndexOf(str4));
            Console.WriteLine("27. LastIndexOfAny ({0}, a-e-i-o-u) : {1} ***", str5, str5.LastIndexOfAny(chars));
            Console.WriteLine("29. PadLeft ({0}) : \"{1}\" ***", str1, str1.PadLeft(10));
            Console.WriteLine("30. PadRight ({0}) : \"{1}\" ***", str1, str1.PadRight(10));
            Console.WriteLine("31. Remove ({0}) : {1} ***", str3, str3.Remove(4, 4));
            Console.WriteLine("32. Replace ({0}) : {1} ***", str11, str11.Replace("docment", "document"));
            Console.WriteLine("34. Split ({0}) : {1}", str5, str5.Split(' ')[0]);
            Console.WriteLine("35. StartsWith");
            Console.WriteLine("36. Substring");
            Console.WriteLine("37. ToCharArray");
            Console.WriteLine("38. ToLower");
            Console.WriteLine("42. ToUpper");
            Console.WriteLine("44. Trim");


            Console.WriteLine();
            Console.WriteLine("DateTime Methods");
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
