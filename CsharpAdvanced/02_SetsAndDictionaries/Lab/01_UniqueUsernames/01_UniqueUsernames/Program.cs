using System;
using System.Collections.Generic;

namespace _01_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list=new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (!list.Contains(input))
                {
                    list.Add(input);
                }
            }

            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
