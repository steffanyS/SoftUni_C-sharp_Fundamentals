using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phoneBook=new Dictionary<string,string>();

            while (input != "search")
            {
                var add = input.Split('-').ToArray();
                var name = add[0];
                var number = add[1];

                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name,number);
                }
                else
                {
                    phoneBook[name] = number;
                }

                input = Console.ReadLine();
            }

                do
                {
                    input = Console.ReadLine();
                    if (phoneBook.ContainsKey(input))
                    {
                        Console.WriteLine("{0} -> {1}",input, phoneBook[input]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",input);
                    }
                } while (input != "stop");
            }
        }
    }

