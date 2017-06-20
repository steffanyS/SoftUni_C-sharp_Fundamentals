using System;
using System.Linq;

namespace _01_StudentsResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var nameString = input.Split('-').ToArray();
                var name = nameString[0].Trim();

                var nameEndIndex = input.IndexOf('-');
                var scoresString = input.Substring(nameEndIndex);

                var scores = scoresString.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                Console.WriteLine(string.Format(
                    "{0,-10}|{1,7:f2}|{2, 7:f2}|{3, 7:f2}|{4, 7:f2}",
                    name, scores[0], scores[1], scores[2], scores.Average()));
            }

            Console.WriteLine(string.Format(
                   "{0,10}|{1,7}|{2,7}|{3,7}|{4,7}",
                   "Name", "CAdv", "COOP", "AdvOOP", "Average"));



        }
    }
}
