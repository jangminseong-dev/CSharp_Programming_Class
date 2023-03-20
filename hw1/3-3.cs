using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Integers(스페이스로 구분) : ");
            string hw3_str = Console.ReadLine();
            var nums = hw3_str.Split(' ');
            List<int> hw3_result = new List<int>();

            foreach (string item in nums)
            {
                int num = int.Parse(item);
                if (!hw3_result.Contains(num)) hw3_result.Add(num);
            }

            Console.WriteLine($"{String.Join(", ", hw3_result)}");
            Console.ReadKey();
        }
    }
}