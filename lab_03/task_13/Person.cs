using System;
using System.Collections.Generic;
using System.Text;

namespace task_13
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public Person(string name, string surname, string birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }
    }
}
