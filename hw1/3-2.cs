using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string hw2_str = Console.ReadLine();
            int count = 0;

            foreach(char ch in hw2_str.ToLower())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    count++;
            }
            Console.WriteLine("The number of vowels is " + count.ToString());
            Console.ReadKey();
        }
    }
}