using System;
using System.Collections.Generic;
using System.Text;

namespace task_01
{
    class Box<T>
    {
        public T Value { get; protected set; }
        public Box(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"{Value.GetType().FullName} : {Value}";
        }
    }
}
