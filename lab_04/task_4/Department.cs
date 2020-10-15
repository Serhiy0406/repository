using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class Department
    {
        public string Name { get; set; }
        public string[,] Room = new string[20,3];
        
        
        public Department(string name, string doctorName, string doctorSurname,string patientName)
        {
            Name = name;
            AddPatient(patientName);
        }
        public void AddPatient(string name)
        {
            int k = 0;
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (Room[i, j] == null)
                    {
                        Room[i, j] = name;
                        k++;
                        break;
                    }
                }
                if (k == 1)
                {
                    break;
                }
            }
        }
        public static bool CheckUnique(string name, List<Department> departments)
        {
            int k = 0;
            for(int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Name == name)
                {
                    k++;
                    break;
                }
            }
            if (k == 0)
                return true;
            else
                return false;
        }
        public void Output()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Room[i, j] != null)
                    {
                        Console.WriteLine($"{Room[i, j]}");
                    }
                }
            }
        }
        public void Output(int n,List<Department> departments)
        {
            List<string> Names = new List<string>();

            n--;
            for (int j = 0; j < 3; j++)
            {
                if (Room[n, j] == null)
                {
                    break;
                }
                else
                {
                    Names.Add(Room[n,j]);
                }
            } 
            for(int i = 0; i < Names.Count; i++)
            {
                for(int j=0; j < Names.Count; j++)
                {
                    if (string.Compare(Names[i],Names[j]) < 0)
                    {
                        string tmp = Names[i];
                        Names[i] = Names[j];
                        Names[j] = tmp;
                    }
                }
            }
            for (int j = 0; j < Names.Count; j++)
            {
                Console.WriteLine(Names[j]);
            }
        }
    }
}
