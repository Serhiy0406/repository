﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Dog : Animal
    {
        public Dog (string name, string food): base(name, food)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf()+Environment.NewLine+"DJAAF";
        }
    }
}
