using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers =
                Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var group0=new List<int>();
            var group1 = new List<int>();
            var group2 = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) % 3 == 0)
                {
                    group0.Add(numbers[i]);
                }
                else if (Math.Abs(numbers[i])%3==1)
                {
                    group1.Add(numbers[i]);
                }
                else if(Math.Abs(numbers[i]) % 3==2)
                {
                    group2.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", group0));
            Console.WriteLine(string.Join(" ", group1));
            Console.WriteLine(string.Join(" ", group2));
        }
    }
}
