using System;
using System.Text;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reversed=new StringBuilder();

            for (int i = input.Length-1; i >=0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
