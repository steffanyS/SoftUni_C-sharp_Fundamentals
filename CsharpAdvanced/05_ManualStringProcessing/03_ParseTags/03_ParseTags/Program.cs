using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var openTag = "<upCase>";
            var closeTag = "</upCase>";

            int startIndex = text.IndexOf(openTag);

            while (startIndex!=-1)
            {
                int endIndex = text.IndexOf(closeTag);

                if (endIndex == -1)
                {
                    break;
                }

                string upcase = text.Substring(startIndex, endIndex - startIndex + closeTag.Length);

                string replaceUpcase = upcase.Replace(openTag, "").Replace(closeTag, "").ToUpper();

                text = text.Replace(upcase, replaceUpcase);
                startIndex = text.IndexOf(openTag);                
            }
            Console.WriteLine(text);
        }
    }
}
