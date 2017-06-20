using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse);

            var stack = new Stack<int>();

            foreach (var num in input)
            {
                stack.Push(num);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop()+" ");
            }
        }
    }
}
