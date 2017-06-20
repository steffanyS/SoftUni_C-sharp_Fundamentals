using System;
using System.Collections.Generic;

namespace _07_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var emails=new Dictionary<string,string>();

            while (input!="stop")
            {
                var name = input;
                var email = Console.ReadLine();

                if (!emails.ContainsKey(name))
                {
                    if ((email[email.Length-1] != 'k' || email[email.Length] != 's') && email[email.Length - 2] != 'u')
                    {
                        emails.Add(name, email);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var key in emails.Keys)
            {
                Console.WriteLine("{0} -> {1}", key, emails[key]);
            }
        }
    }
}
