using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var graduation=new SortedDictionary<string,double>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var scores = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                var average = scores.Average();

                graduation.Add(name,average);
            }

            foreach (var kvp in graduation)
            {
                Console.WriteLine("{0} is graduated with {1}", kvp.Key,kvp.Value);
            }
        }
    }
}
