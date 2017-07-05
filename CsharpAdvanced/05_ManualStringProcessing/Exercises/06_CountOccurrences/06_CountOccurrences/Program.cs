using System;

namespace _06_CountOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var found = text.IndexOf(pattern, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
