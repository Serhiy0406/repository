using System;
using System.Collections.Generic;
using System.Text;

namespace task_9
{
    class Node<T>
    {
        public T Value { get; set; }
        
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
