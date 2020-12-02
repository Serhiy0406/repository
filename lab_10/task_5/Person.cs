using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Person:IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person person)
        {
            if (this.Name.CompareTo(person.Name) != 0)
            {
                return this.Name.CompareTo(person.Name);
            }else if (this.Age.CompareTo(person.Age) != 0)
            {
                return this.Age.CompareTo(person.Age);
            }
            else
            {
                return this.Town.CompareTo(person.Town);
            }
        }
    }
}
