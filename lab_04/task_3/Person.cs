using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    abstract class Person
    {
        public List<int> Stars = new List<int>();
        public int row { get; set; }
        public int col { get; set; }
        public int Suma { get; set; }
        abstract public void AddElements(Galaxi galaxi);
    }

    class Ivo : Person 
    {
        public override void AddElements(Galaxi galaxi)
        {
            int n = row;
            int m = col;
            while (m<galaxi.dimention.GetLength(1) && n>=0) 
            {
                Stars.Add(galaxi.dimention[n,m]);
                Suma += galaxi.dimention[n, m];
                n--;
                m++;
            }
        }
    }
    class Evil : Person
    {
        public override void AddElements(Galaxi galaxi)
        {
            int n = row;
            int m = col;
            while (n>=0 && m>=0)
            {
                Stars.Add(galaxi.dimention[n, m]);
                Suma += galaxi.dimention[n, m];
                n--;
                m--;
            }
        }
    }
}
