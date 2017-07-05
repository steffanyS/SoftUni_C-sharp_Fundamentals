using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_AshesOfRoses
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, decimal>> flowers = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine != "Icarus, Ignite!")
            {

                Regex regex = new Regex(@"\b^Grow <([A-Z][a-z]*)> <([a-zA-Z\d]+)> (\d+)$");

                Match match = regex.Match(inputLine);

                while (match.Groups[0].Value == "")
                {
                    inputLine = Console.ReadLine();
                    if (inputLine == "Icarus, Ignite!")
                    {
                        break;
                    }
                    match = regex.Match(inputLine);
                }
                if (inputLine == "Icarus, Ignite!")
                {
                    break;
                }
                string region = match.Groups[1].Value;
                string color = match.Groups[2].Value;
                decimal number = decimal.Parse(match.Groups[3].Value);

                if (!flowers.ContainsKey(region))
                {
                    flowers.Add(region, new Dictionary<string, decimal>());
                }
                if (!flowers[region].ContainsKey(color))
                {
                    flowers[region].Add(color, 0);
                }
                flowers[region][color] += number;

                inputLine = Console.ReadLine();
            }


            foreach (var outerPair in flowers.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key))
            {
                Console.WriteLine("{0}", outerPair.Key);

                foreach (var innerPair in outerPair.Value.OrderBy(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine("*--{0} | {1}", innerPair.Key, innerPair.Value);
                }
            }
        }
    }
}

