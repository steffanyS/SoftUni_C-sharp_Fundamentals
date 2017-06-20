using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack=new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var query = input[0];   

                if (query == 1)
                {
                    stack.Push(input[1]);
                }
                else if (query==2)
                {
                    stack.Pop();
                }
                else if (query==3)
                {
                    Console.WriteLine(stack.Max());
                }

            }
        
        }
    }
}
