using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Cat: Animal
    {
        public Cat(string name, string food):base(name, food)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf()+Environment.NewLine+"MEEOW";
        }
    }
}
