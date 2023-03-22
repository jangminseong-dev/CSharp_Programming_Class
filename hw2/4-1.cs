using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int j = 1; j <= 1000; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    sum += j;
                }
            }
            Console.WriteLine("Reuslt : " + sum.ToString());
        }
    }
}