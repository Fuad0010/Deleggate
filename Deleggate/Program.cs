using System;
using System.Collections.Generic;

namespace Deleggate
{
    internal class Program
    {
        delegate void Write1<T, U>(T str1, U str2);
        delegate int Grade(int num1, int num2);
        static void Main(string[] args)
        {

            Action<int, int> test1 = (n, m) => Console.WriteLine(m - n);
            Predicate<string> test2 = m => m.Length > 5;
            Func<int, int, string> test3 = (n, m) => "test";

            Console.WriteLine(Sum(new int[] { 2, 4, 1, 5, 8 }, n => n % 2 == 0));


            Grade grade = Summer;
            grade += delegate (int b, int z)
             {
                 return b + z;
             };

            grade += (n1, n2) =>
           {
               return n2 - n1;
           };

            Console.WriteLine(grade(2, 45));



            List<int> numbers = new List<int>();
            {
                numbers.Add(1);
                numbers.Add(4);
                numbers.Add(23);
                numbers.Add(42);

                int num = numbers.Find(n => n > 2);
                //Console.WriteLine(num);
                List<int> nums = numbers.FindAll(n => n > 2);
                foreach(var item in nums)
                {
                    Console.WriteLine(item);
                }

            }












        }
        static int Summer(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Sum(int[] arr, Predicate<int> func)
        {
            int result = 0;
            foreach (var item in arr)
            {
                if (func(item))
                {
                    result += item;
                }
            }
            return result;
        }
    }
}
