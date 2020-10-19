using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    abstract class Treasure
    {
        public List<string> Type { get; set; } = new List<string>();
        public List<int> Amount { get; set; } = new List<int>();
        public int totalAmount { get; set; }
        public Treasure()
        {
            totalAmount = 0;
        }
        public void Add(string type, int value)
        {
            Type.Add(type);
            Amount.Add(value);
            totalAmount += value;
        }

    }
}
