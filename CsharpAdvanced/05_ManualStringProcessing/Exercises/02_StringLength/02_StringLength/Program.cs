using System;
using System.Text;

namespace _02_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output=new StringBuilder();

            if (input.Length < 20)
            {
                output.Append(input);
                output.Append('*', 20 - input.Length);
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }
            }

            Console.WriteLine(output);
        }
    }
}
