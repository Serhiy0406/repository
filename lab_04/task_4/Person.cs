using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    abstract class Person
    {
        public string Name { get; set; }


    }

    class Patient:Person
    {
        public Patient(string name)
        {
            Name = name;
        }
    }

    class Doctor : Person
    {
        public string Surname { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public Doctor(string name, string surname, string patientName)
        {
            Name = name;
            Surname = surname;
            Patients.Add(new Patient(patientName));
        }
        public static bool CheckUnique(string name,string surname, List<Doctor> doctorslist)
        {
            for (int i = 0; i < doctorslist.Count; i++)
            {
                if (doctorslist[i].Name == name)
                {
                    return false;
                }
            }
            return true;
        }
        public static void SortAndOutputPatients(string name, string surname, List<Doctor> doctorslist)
        {
            for (int i = 0; i < doctorslist.Count; i++)
            {
                if (name == doctorslist[i].Name && surname == doctorslist[i].Surname)
                {
                    for (int k = 0; k < doctorslist[i].Patients.Count; k++)
                    {
                        for (int l = 0; l < doctorslist[i].Patients.Count - 1; l++)
                        {
                            if (string.Compare(doctorslist[i].Patients[k].Name, doctorslist[i].Patients[l].Name) < 0)
                            {
                                string tmp = doctorslist[i].Patients[k].Name;
                                doctorslist[i].Patients[k].Name = doctorslist[i].Patients[l].Name;
                                doctorslist[i].Patients[l].Name = tmp;
                            }
                        }
                    }
                    for (int j = 0; j < doctorslist[i].Patients.Count; j++)
                    {
                        Console.WriteLine(doctorslist[i].Patients[j].Name);
                    }
                }
            }
        }
        public void AddPatient(string patientName)
        {
            Patients.Add(new Patient(patientName));
        }
    }

}
