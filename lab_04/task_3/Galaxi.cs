using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Galaxi
    {
        public List<int> Ivo = new List<int>();
        public List<int> Evil = new List<int>();
        public int[,] dimention;
        public void Input(int n, int m)
        {
            dimention = new int[n, m];
            int value = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    dimention[i,j] = value;
                    value++;
                }
            }
        }
        public void IvoAdd(int x, int y)
        {
            int max_i = dimention.GetLength(0);
            int max_j = dimention.GetLength(1);
            do
            {           
                Ivo.Add(dimention[x, y]);
                x++;
                y++;
            }
            while (max_i > x && max_j > y);
        }
        public void EvilAdd(int x, int y)
        {
            int max_i = dimention.GetLength(0)-1;
            int max_j = dimention.GetLength(1)-1;
            do
            {                
                Evil.Add(dimention[x, y]);
                x++;
                y++;
            }
            while (max_i > x && max_j > y);
        }

        public void Check()
        {
            for(int i = 0; i < Ivo.Count; i++)
            {
                for(int j = 0; j < Evil.Count; j++)
                {
                    if (Ivo[i] == Evil[j])
                        Ivo.RemoveAt(i);
                }
            }
        }

        public int Suma()
        {
            int suma = 0;
            for (int j = 0; j < Ivo.Count; j++)
            {
                suma += Ivo[j];
            }
            return suma;
        }
    }
}
