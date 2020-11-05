using System;
using System.Collections.Generic;
using System.Text;

namespace task_6.AimalClasses
{
    class Frog:Animal
    {
        public override string ProduceSound()
        {
            return "Ribbit";
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine(ProduceSound());
            return resultBuilder.ToString();
        }
        public Frog (string name , int age, string gender)
            :base(name, age, gender)
        {

        }
    }
}
