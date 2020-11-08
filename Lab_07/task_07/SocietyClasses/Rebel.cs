using System;
using System.Collections.Generic;
using System.Text;
using task_05;

namespace task_07.SocietyClasses
{
    class Rebel: Society
    {
        private string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public Rebel(string name, int age, string group)
            :base(name,age)
        {
            Group = group ;
        }
        
        public override void BuyFood()
        {
            Food += 5;
        }
    }
}
