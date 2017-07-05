using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0004
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
                    int count = department[departmentName].Count;
                    if (count <= 20)
                    {
                        department[departmentName].Add(patient, 3);
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


            var orderedDep = department.OrderBy(x => x.Value);

            input = Console.ReadLine();
            while (input != "End")
            {
                var isDoctor = false;
                var isDepartment = false;
                var isDepartmentRoom = false;
                int value;

                var dataInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (dataInput.Length <= 1)
                {
                    isDepartment = true;
                }
                else if (int.TryParse(dataInput[1], out value))
                {
                    isDepartmentRoom = true;
                }
                else
                {
                    isDoctor = true;
                }

                if (isDoctor)
                {
                    foreach (var kvp in doctor[dataInput[0] + " " + dataInput[1]])
                    {
                        Console.WriteLine(kvp);
                    }
                }
                else if (isDepartment)
                {
                    foreach (var kvp in department[input])
                    {

                        Console.WriteLine(kvp.Key);
                    }
                }
                else if (isDepartmentRoom)
                {
                    foreach (var kvp in department[dataInput[0]])
                    {
                        if (kvp.Value == int.Parse(dataInput[1]))
                        {
                            Console.WriteLine(kvp.Key);
                        }
                    }
                }

                isDoctor = false;
                isDepartment = false;
                isDepartmentRoom = false;
                input = Console.ReadLine();
            }

            //foreach (var kvp in department["Cardiology"])
            //{

            //        Console.WriteLine(kvp.Key);

            //}
        }
    }
}

