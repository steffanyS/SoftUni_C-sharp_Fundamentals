using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ');
            var stack=new Stack<string>(values.Reverse());

            foreach (var value in values)
            {
                stack.Push(value);
            }

            while (stack.Count>1)
            {
                var firstNumber=int.Parse(stack.Pop());
                var operation = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());
                var result = 0;
                if (operation == "+")
                {
                    result = firstNumber+secondNumber;
                }
                else if(operation=="-")
                {
                    result = firstNumber + secondNumber;
                }

                stack.Push(result.ToString());
                
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
