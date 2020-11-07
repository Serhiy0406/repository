using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace task_05
{
    class Citizen: Society
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Citizen(string name, int age, string id)
            :base(name, id)
        {
            Age = age;
        }
        
    }
}
