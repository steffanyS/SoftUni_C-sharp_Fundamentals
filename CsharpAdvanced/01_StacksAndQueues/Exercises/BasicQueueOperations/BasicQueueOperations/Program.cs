using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue=new Queue<int>();

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nsx[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < nsx[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(nsx[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

            
        }
    }
}
