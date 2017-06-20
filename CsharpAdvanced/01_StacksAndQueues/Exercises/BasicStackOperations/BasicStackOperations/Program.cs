using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack=new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var s = nsx[1];
            var x = nsx[2];

            while (s > 0)
            {
                stack.Pop();
                s--;
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

            var minNumber = stack.Min();

            while (stack.Count > 0)
            {
                var number = stack.Pop();
                if (number == x)
                {
                    Console.WriteLine("true");
                    break;
                }
                else if (stack.Count == 1)
                {
                    Console.WriteLine(minNumber);
                }
            }
            
        }
    }
}
