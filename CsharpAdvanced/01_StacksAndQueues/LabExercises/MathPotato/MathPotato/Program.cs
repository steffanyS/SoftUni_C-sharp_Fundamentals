using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var queue=new Queue<string>(input);
            int cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if()

                cycle++;

            }

            Console.WriteLine($"Last in {queue.Dequeue()}");
        }

    }
}
