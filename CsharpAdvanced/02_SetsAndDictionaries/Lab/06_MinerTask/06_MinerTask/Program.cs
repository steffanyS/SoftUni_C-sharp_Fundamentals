using System;
using System.Collections.Generic;

namespace _06_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var miner=new Dictionary<string, long>();

            while (input!="stop")
            {
                var resource = input;
                var quantity = long.Parse(Console.ReadLine());

                if (!miner.ContainsKey(resource))
                {
                    miner.Add(resource,quantity);
                }
                else
                {
                    miner[resource] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var key in miner.Keys)
            {
                Console.WriteLine("{0} -> {1}", key, miner[key]);
            }
        }
    }
}
