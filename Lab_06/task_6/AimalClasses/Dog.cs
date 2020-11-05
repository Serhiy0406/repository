using System;
using System.Collections.Generic;
using System.Text;

namespace task_6.AimalClasses
{
    class Dog : Animal
    {
        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine(ProduceSound());
            return resultBuilder.ToString();
        }
        public Dog(string name, int age, string gender)
            :base(name , age , gender)
        {

        }
    }
}
