using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            while (decimalNumber != 0)
            {
                stack.Push(decimalNumber % 2);
                decimalNumber/=2;
            }

            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
