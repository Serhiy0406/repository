using System;
using System.Linq;
using System.Collections.Generic;
namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Job> jobs = new List<Job>();
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "End") { break; }
                else
                {
                    switch (str[0]) 
                    {
                        case "StandardEmployee":
                            employees.Add(new StandartEmployee(str[1]));
                            break;
                        case "PartTimeEmployee":
                            employees.Add(new PartTimeEmployee(str[1]));
                            break;
                        case "Pass":
                            foreach(var item in jobs)
                            {
                                item.Update();
                            }
                            break;
                        case "Status":

                            foreach (var item in jobs)
                            {
                                if (item.data.HoursRequired <= 0) { Console.WriteLine($"Job {item.data.Name} done!"); }
                                else { Console.WriteLine($"Job: {item.data.Name} Hours Remaining: {item.data.HoursRequired}"); }
                            }
                            break;
                        case "Job":
                            var x = employees.Find(element => element.Name == str[3]);
                            jobs.Add(new Job(str[1], int.Parse(str[2]), x));
                            break;
                    }
                } 
                    
            }
            Console.ReadKey();
        }
    }
}
