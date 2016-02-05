using System;
using System.Collections.Generic;
using System.Linq;

namespace ItaTask_1
{
    class DemonstrationFirstMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the second name");
            string secondName = Console.ReadLine();
            Console.WriteLine("When you have entered all the names you want please enter 'stop'");
            List<LeaderEmployeePair> pairOfEmployee = new List<LeaderEmployeePair>();

            string inputPairName = "";
            string endInput = "";
            while (endInput != "stop")
            {
                inputPairName = Console.ReadLine();
                if (inputPairName == "stop")
                {
                    endInput = "stop";
                    continue;
                }
                String[] separatedNames = inputPairName.Split('-');
                pairOfEmployee.Add(new LeaderEmployeePair { Boss = separatedNames[0].Trim(), Employee = separatedNames[1].Trim() });
            }

            if (pairOfEmployee.Count == 1 || pairOfEmployee.Count == 0)
            {
                Console.WriteLine("You have not entered enough data for the task to be executed.");
                Console.WriteLine();
            }
            else
            {
                try
                {
                    pairOfEmployee.Reverse();
                    List<string> firstNameLeaders = new List<string>();
                    List<string> secondNameLeaders = new List<string>();
                    foreach (var pair in pairOfEmployee)
                    {
                        if (pair.Employee == firstName)
                        {
                            firstNameLeaders.Add(pair.Boss);
                            firstName = pair.Boss;
                        }
                        if (pair.Employee == secondName)
                        {
                            secondNameLeaders.Add(pair.Boss);
                            secondName = pair.Boss;
                        }
                    }
                    Console.WriteLine(firstNameLeaders.Intersect(secondNameLeaders).First());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Due to invalid data provided, the task cannot be executed.More information:");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
