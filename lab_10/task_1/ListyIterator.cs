﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class ListyIterator<T>
    {
        private int index = 0;
        public int Index { get { return index; } set { index = value; } }
        List<T> LIst { get; set; } = new List<T>();
        public ListyIterator()
        {
        }
        public ListyIterator(List<T> elements)
        {
            foreach (var i in elements)
            {
                LIst.Add(i);
            }
        }
        public  bool HasNext()
        {
            if (Index==LIst.Count-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public  void Print()
        {
            if (LIst.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(LIst[Index]);
            }
        }
        public  bool Move()
        {
            if (Index == LIst.Count - 1)
            {
                return false;
            }
            else { Index += 1; return true; }
        }
    }
}
