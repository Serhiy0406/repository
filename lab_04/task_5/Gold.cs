using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Gold : Treasure
    {
        public void Output()
        {
            Console.WriteLine($"<Gold> ${totalAmount}");
            Console.WriteLine($"##Gold - {totalAmount}");
        }
    }
}
