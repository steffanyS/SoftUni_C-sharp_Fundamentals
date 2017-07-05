using System;
using System.Collections.Generic;
using System.Text;

namespace _03_NMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var words=new List<string>();

            while (input != "---NMS SEND---")
            {
                words.Add(input);
                input = Console.ReadLine();
            }

            var delimiter = Console.ReadLine();

            var letters=new List<char>();
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    letters.Add(character);
                }
            }

            var message=new StringBuilder();
            message.Append(letters[0]);

            for (int i = 1; i < letters.Count; i++)
            {
                if (char.ToLower(letters[i-1]) <= char.ToLower(letters[i]))
                {
                    message.Append(letters[i]);
                }
                else
                {
                    message.Append(delimiter);
                    message.Append(letters[i]);
                }
            }

            Console.WriteLine(message);
        }
    }
}
