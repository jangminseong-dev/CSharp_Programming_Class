using System;
using System.Text.RegularExpressions;

#pragma warning disable 0168
#pragma warning disable 8600
#pragma warning disable 8604
#pragma warning disable 8602

namespace std
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int test;
            //1번 문제
            int sum = 0;
            for (int j = 1; j <= 1000; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    sum += j;
                }
            }
            Console.WriteLine("Reuslt : " + sum.ToString());

            //2번 문제
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
            }
            Console.Write("\n");

            //3번 문제
            int n = 30;
            int[] fib = new int[n];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
                fib[i] = fib[i - 1] + fib[i - 2];

            for (int i = 0; i < n; i++)
                Console.WriteLine("fibonacci({0}) = {1}", i, fib[i]);

            //4번 문제
            Console.Write("Enter Integer : ");
            int num4 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num4; i++)
            {
                if (num4 % i == 0)
                    Console.Write(i.ToString() + " ");
            }
            Console.Write("\n");

            //5번 문제
            Console.Write("Enter Integer : ");
            int result5 = 1, num5 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num5; i++)
                result5 *= i;
            Console.WriteLine("Reuslt : " + result5.ToString());

            //6번 문제
            int result6 = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                    result6 += i;
            }
            Console.WriteLine("Result = " + result6.ToString());

            //7번 문제
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

            //8번 문제
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