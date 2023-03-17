using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Sentense : ");
            string hw6_str = Console.ReadLine();
            string hw6_result = Regex.Replace(hw6_str, @"\d", "");
            Console.WriteLine($"{hw6_result.ToUpper()}");
            Console.ReadKey();
        }
    }
}