using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vip=new HashSet<string>();
            var regular=new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                if (IsVip(input))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (IsVip(input))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }

            regular.UnionWith(vip);

            Console.WriteLine(regular.Count);
            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }
        }

        public static bool IsVip(string input)
        {
            Regex regex= new Regex("^\\d\\w*");
            MatchCollection matches = regex.Matches(input);

            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
