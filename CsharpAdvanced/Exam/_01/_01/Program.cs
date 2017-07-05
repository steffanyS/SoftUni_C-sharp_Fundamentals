using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex=new Regex(@"\[[a-zA-Z]+<([0-9]+)REGEH([0-9]+)>[a-zA-Z]+\]");

            var result=new StringBuilder();

            MatchCollection matches = regex.Matches(input);

            var numbers=new List<int>();


            foreach (Match match in matches)
            {
                numbers.Add(int.Parse(match.Groups[1].ToString()));
                numbers.Add(int.Parse(match.Groups[2].ToString()));
            }


            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            var currentNumber = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    currentNumber += numbers[j];
                    
                }
                //Console.WriteLine(currentNumber);
                if (currentNumber < input.Length)
                {
                    result.Append(input[currentNumber]);
                }
                else
                {
                    while (currentNumber > input.Length)
                    {
                        currentNumber -= input.Length;
                    }

                    result.Append(input[currentNumber]);
                }

                currentNumber = 0;
            }

           Console.WriteLine(result);
        }
    }
}
