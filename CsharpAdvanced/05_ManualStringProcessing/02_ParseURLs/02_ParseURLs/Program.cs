using System;

namespace _02_ParseURLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string[] reminder = input.Split(new char[] {':','/','/'});
            string protocol = reminder[0];

            int serverEndIndex = reminder[1].IndexOf("/");
            string server = reminder[1].Substring(0, serverEndIndex);
            string resourse = reminder[1].Substring(serverEndIndex + 1);

            if (!input.Contains("/") || !input.Contains("://"))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                Console.WriteLine("Protocol = " + protocol);
                Console.WriteLine("Server = " + server);
                Console.WriteLine("Resourse = " + resourse);
            }

        }
    }
}
