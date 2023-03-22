using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Integer : ");
            int num4 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num4; i++)
            {
                if (num4 % i == 0)
                    Console.Write(i.ToString() + " ");
            }
            Console.Write("\n");
        }
    }
}