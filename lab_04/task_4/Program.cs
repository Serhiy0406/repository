using System;
using System.Collections.Generic;
namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            List<Doctor> doctorslist = new List<Doctor>();
            for(int i=0; i < 30; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Output")
                {
                    break;
                }
                else
                {
                    if (Doctor.CheckUnique(s[1], s[2], doctorslist))
                        doctorslist.Add(new Doctor(s[1], s[2], s[3]));
                    else
                    {
                        for(int j = 0; j < doctorslist.Count; j++)
                        {
                            if(s[1]==doctorslist[j].Name && s[2] == doctorslist[j].Surname)
                            {
                                doctorslist[j].AddPatient(s[3]);
                            }
                        }
                    }
                    if (Department.CheckUnique(s[0], departments) == true)
                    {
                        departments.Add(new Department(s[0],s[1],s[2],s[3]));
                    }
                    else
                    {
                        for(int j = 0; j < departments.Count; j++)
                        {
                            if (departments[j].Name == s[0])
                            {
                                departments[j].AddPatient(s[3]);
                            }
                        }
                    } 
                    
                }
            }
            string[] s1 = Console.ReadLine().Split(' ');
            if (s1.Length==1)
            {
                for(int i = 0; i < departments.Count; i++)
                {
                    if (departments[i].Name == s1[0])
                    {
                        departments[i].Output();
                    }
                }     
            }else if(s1.Length == 2)
            {
                if(int.TryParse(s1[1], out int int_value))
                {
                    
                    for (int i = 0; i < departments.Count; i++)
                    {
                        if (departments[i].Name == s1[0])
                        {
                            departments[i].Output(int_value,departments);
                        }
                    }
                }
                else
                {
                    Doctor.SortAndOutputPatients(s1[0], s1[1], doctorslist);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
