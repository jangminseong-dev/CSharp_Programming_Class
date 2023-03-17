using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Integers(스페이스로 구분) : ");
            string hw5_str = Console.ReadLine();
            int[] hw5_result = Array.ConvertAll(hw5_str.Split(' '), int.Parse);

            Array.Sort(hw5_result);
            Console.WriteLine($"{String.Join(", ", hw5_result)}");
            Console.ReadKey();
        }
    }
}