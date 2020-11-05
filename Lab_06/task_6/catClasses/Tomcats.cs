using System;
using System.Collections.Generic;
using System.Text;
using task_6.AimalClasses;

namespace task_6.catClasses
{
    class Tomcats: Cat
    {
        public override string Gender 
        {
            get => base.Gender; 
            set => base.Gender = "Male"; 
        }
        public Tomcats(string name, int age, string gender)
        :base(name , age , gender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{Name} {Age} {Gender}")
                .AppendLine(ProduceSound());
            string result = resultBuilder.ToString();
            return result;
        }
    }
}
