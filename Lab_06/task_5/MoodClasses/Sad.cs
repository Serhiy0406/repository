using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.MoodClasses
{
    class Sad: MoodFactory
    {
        public override void Output()
        {
            Console.WriteLine("Sad");
        }
    }
}
