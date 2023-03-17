using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string hw7_str = "";
            Console.Write("Enter Integer : ");
            hw7_str = Console.ReadLine();
            if (Regex.Replace(hw7_str, @"[^0-9]", "") != "")
            {
                Console.WriteLine(Convert.ToString(int.Parse(hw7_str), 2));
            }
            else
                Console.WriteLine("Error: Input is only integer.");
            Console.ReadKey();
        }
    }
}