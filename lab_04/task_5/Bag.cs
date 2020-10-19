using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Bag
    {
        public int Limit { get; set; }
        public int amount { get; set; }
        public Bag()
        {
            amount = 0;
        }
        public void AddLimit(int value)
        {
            Limit = value;
        }
        public bool checkLimit(int value)
        {
            if(amount + value > Limit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
