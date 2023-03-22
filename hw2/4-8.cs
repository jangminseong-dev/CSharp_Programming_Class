using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string str8 = Console.ReadLine();
            string[] array8 = str8.Split(' ');

            for (int i = 0; i < array8.Length; i++)
            {
                if (!string.IsNullOrEmpty(array8[i]))
                    array8[i] = array8[i][0].ToString().ToUpper() + array8[i].Substring(1);
            }
            Console.WriteLine($"{String.Join(" ", array8)}");
        }
    }
}