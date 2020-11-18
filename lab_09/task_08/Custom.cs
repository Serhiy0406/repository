using System;
using System.Collections.Generic;
using System.Text;

namespace task_08
{
    class Custom<T>
    {
        public List<T> List { get; protected set; } = new List<T>();
        public void Add(T elemrnt)
        {
            List.Add(elemrnt);
        }
        public T Remove(int index)
        {
            T str = List[index];
            List.RemoveAt(index);
            return str;
        }
        public bool Contains(T element)
        {
            if (List.Contains(element)) { return true; }
            else return false;
        }
        public void Swap(int index1, int index2)
        {
            T tmp = List[index1];
            List[index1] = List[index2];
            List[index2] = tmp;
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var i in List)
            {
                if (Comparer<T>.Default.Compare(i, element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            T max = List[0];
            foreach (var i in List)
            {
                if (Comparer<T>.Default.Compare(i, max) > 0) { max = i; }
            }
            return max;
        }
        public T Min()
        {
            T min = List[0];
            foreach (var i in List)
            {
                if (Comparer<T>.Default.Compare(i, min) < 0) { min = i; }
            }
            return min;
        }
        public void Print()
        {
            foreach (var i in List)
            {
                Console.WriteLine(i);
            }
        }
    }
}
