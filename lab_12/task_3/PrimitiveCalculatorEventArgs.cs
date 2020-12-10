using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    public class PrimitiveCalculatorEventArgs: EventArgs
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public char Operation { get; set; }
        public PrimitiveCalculatorEventArgs(int number1, int number2, char operator_)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operator_;
        }
    }
}
