using System;
using System.Collections.Generic;
using System.Text;

namespace task_05
{
    class Society: IBuyer
    {
        private string name;
        private int age;
        private int food = 0;
        public int Food 
        {
            get { return food; }
            set { food = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }
        public Society(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void BuyFood()
        {
        }
    }
}
