using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string hw1_str = "";
            Console.Write("Enter Integer : ");
            hw1_str = Console.ReadLine();
            if (Regex.Replace(hw1_str, @"[^0-9]", "") != "")
            {
                if (int.Parse(hw1_str) > 0)
                    Console.WriteLine(hw1_str + " is positive number.");
                else if (int.Parse(hw1_str) < 0)
                    Console.WriteLine(hw1_str + " is negative number.");
                else
                    Console.WriteLine(hw1_str + " is Zero.");
            }
            else
                Console.WriteLine("Error: Input is only integer.");
            Console.ReadKey();
        }
    }
}