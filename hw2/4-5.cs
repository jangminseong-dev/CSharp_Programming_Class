using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Integer : ");
            int result5 = 1, num5 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num5; i++)
                result5 *= i;
            Console.WriteLine("Reuslt : " + result5.ToString());
        }
    }
}