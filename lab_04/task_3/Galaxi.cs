using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Galaxi
    {
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
        public static void Compare(Ivo ivo, Evil evil)
        {
            for(int i = 0; i < ivo.Stars.Count; i++)
            {
                for(int j = 0; j < evil.Stars.Count; j++)
                {
                    if (ivo.Stars[i] == evil.Stars[j])
                    {   
                        ivo.Suma -= ivo.Stars[i];
                        break;
                    }
                }
            }
        }
    }
}
