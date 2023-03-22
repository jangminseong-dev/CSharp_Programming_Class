using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string str7 = Console.ReadLine().ToLower();

            int[] array = new int[26];
            
            foreach (char c in str7)
            {
                if (char.IsLetter(c))
                    array[c - 'a']++;
            }
            int result7 = Array.IndexOf(array, array.Max());
            Console.WriteLine("Result : {0}",(char)('a' + result7));
        }
    }
}