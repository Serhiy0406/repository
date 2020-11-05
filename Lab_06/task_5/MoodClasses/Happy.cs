using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.MoodClasses
{
    class Happy:MoodFactory
    {
        public override void Output()
        {
            Console.WriteLine("Happy");
        }
    }
}
