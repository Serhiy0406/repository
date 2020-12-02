using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task_9
{
    class Linked_list<T> : IEnumerable<T>
    {
        public Node<T> First = null;
        public Node<T> Last = null;
        List<Node<T>> List { get; set; } = new List<Node<T>>();
        public int Count { get; set; }
        

        public void Add(T item)
        {
            if (First == null)
            {
                var node = new Node<T>(item);
                First = node;
                Last = node;
                List.Add(node);
                node.Next = null;
                node.Prev = null;
                Count = 1;
            }
            else
            {
                var node = new Node<T>(item);
                Last.Next = node;
                node.Prev = Last;
                Last = node;
                node.Next = null;             
                List.Add(node);              
                Count++;
            }
        }
        public bool Remove(T value)
        {
            if (First!=null && First.Value.Equals(value))
            {
                First = First.Next;
                First.Prev = null;
                Count--;
                return true;
            }
            Node<T> tmp = First;
            while (tmp.Next != null)
            {
                if (tmp.Value.Equals(value))
                {
                    var prev = tmp.Prev;
                    var next = tmp.Next;
                    prev.Next = next;
                    next.Prev = prev;
                    tmp.Next = null;
                    tmp.Prev = null;
                    List.Remove(tmp);
                    Count--;
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }
        

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> tmp = First;
            while (tmp.Next != null)
            {
                yield return tmp.Value;
                tmp = tmp.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
