using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = new Dictionary<string, Dictionary<string, int>>();
            var doctor = new Dictionary<string, List<string>>();
            var room = 1;
            var bed = 0;
            var input = Console.ReadLine();

            while (input != "Output")
            {
                var data = input.Split(' ').ToArray();

                var departmentName = data[0];
                var doctorName = data[1] + " " + data[2];
                var patient = data[3];


                if (!department.ContainsKey(departmentName))
                {
                    department.Add(departmentName, new Dictionary<string, int>());
                    department[departmentName].Add(patient, 1);
                }
                else
                {
                    var count = department[departmentName].Count;
                    if (count < 20)
                    {
                        department[departmentName].Add(patient, count / 3);
                    }
                }

                if (!doctor.ContainsKey(doctorName))
                {
                    doctor.Add(doctorName, new List<string>());
                    doctor[doctorName].Add(patient);
                }
                else
                {
                    doctor[doctorName].Add(patient);
                }

                input = Console.ReadLine();
            }

            while (input != "End")
            {
                var doctorRegex = new Regex("[a-zA-Z]+ [a-zA-Z]+");
                var departmentRegex = new Regex("^[a-zA-Z]+$");
                var departmentRoomRegex = new Regex("^[a-zA-Z]+ [0-9]+$");

                if (doctorRegex.IsMatch(input))
                {
                    foreach (var kvp in doctor[input])
                    {
                        foreach (var pat in kvp)
                        {
                            Console.WriteLine(pat);
                        }    
                    }
                }
                else if (departmentRegex.IsMatch(input))
                {
                    //foreach (var kvp in department[input])
                    //{

                    //    Console.WriteLine(kvp.Key);
                    //}
                }
                else if (departmentRoomRegex.IsMatch(input))
                {
                    //foreach (var kvp in department[input])
                    //{
                    //    if (int.Parse(input) == kvp.Value)
                    //    {
                    //        Console.WriteLine(kvp.Key);
                    //    }     
                    //}
                }
                input = Console.ReadLine();
            }
        }
    }
}
