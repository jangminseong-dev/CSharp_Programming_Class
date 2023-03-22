using System;
using System.Text.RegularExpressions;

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 30;
            int[] fib = new int[n];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
                fib[i] = fib[i - 1] + fib[i - 2];

            for (int i = 0; i < n; i++)
                Console.WriteLine("fibonacci({0}) = {1}", i, fib[i]);
        }
    }
}