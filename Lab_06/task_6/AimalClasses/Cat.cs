using System;
using System.Collections.Generic;
using System.Text;

namespace task_6.AimalClasses
{
    class Cat:Animal
    {
        public override string ProduceSound()
        {
            return "Meow meow";
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine(ProduceSound());
            return resultBuilder.ToString();
        }
        public Cat(string name, int age , string gender)
            :base(name, age, gender)
        {

        }
    }
}
