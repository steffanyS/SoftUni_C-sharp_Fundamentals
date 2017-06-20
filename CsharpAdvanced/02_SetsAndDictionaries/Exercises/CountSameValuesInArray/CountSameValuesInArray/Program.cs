using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var numbersDictionary=new SortedDictionary<double,int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersDictionary.ContainsKey(numbers[i]))
                {
                    numbersDictionary.Add(numbers[i],1);
                }
                else
                {
                    numbersDictionary[numbers[i]] += 1;
                }
            }

            foreach (var kvp in numbersDictionary)
            {
                Console.WriteLine("{0} - {1} times",kvp.Key, kvp.Value);
            }
        }
    }
}
