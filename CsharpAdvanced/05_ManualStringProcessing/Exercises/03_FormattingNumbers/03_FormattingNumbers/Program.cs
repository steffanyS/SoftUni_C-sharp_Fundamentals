using System;
using System.Linq;

namespace _03_FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var firstNumber = int.Parse(numbers[0]);
            var secondNumber = double.Parse(numbers[1]);
            var thirdNumber = double.Parse(numbers[2]);

            var firstHex = firstNumber.ToString("X");
            var firstBinary = Convert.ToString(firstNumber, 2);
            

            Console.Write("|");
            Console.Write(firstHex);
            Console.Write(new string(' ', 10-firstHex.Length));
            Console.Write("|");
            Console.Write(firstBinary.PadLeft(10, '0'));
            Console.Write("|");
            Console.Write(new string(' ', 10 - secondNumber.ToString().Length));
            Console.Write("{0:n2}", secondNumber);
            Console.Write("|");
            Console.Write("{0:n3}", thirdNumber);
            Console.Write(new string(' ', 10 - thirdNumber.ToString().Length));
            Console.Write("|");
        }
    }
}
