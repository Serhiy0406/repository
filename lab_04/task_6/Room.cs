using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class Room
    {
        public char[,] place;
        public void Create(int n)
        {
            place = new char[n, 13];
        }
        public void Fill(string s,int i)
        {
            for(int j = 0; j < s.Length; j++)
            {
                place[i, j] = s[j];
            }
        }
        public void Output()
        {
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    Console.Write(place[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public bool Check()
        {
            bool b = false;
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    if (place[i, j] == 'S')
                    {
                        for(int k = 0; k < place.GetLength(1);k++)
                        {
                            if ((place[i,k]=='d' && j<k)||(place[i, k] == 'b' && j > k))
                            {
                                place[i, j] = 'X';
                                Console.WriteLine($"Sam died at {i}, {j}");
                                Output();
                                b = true;
                                return b;
                            }
                            //if ((place[i, k] == 'N' && j <= k) || (place[i, k] == 'N' && j >= k))
                            if(place[i,k]=='N')
                            {
                                place[i, k] = 'X';
                                Console.WriteLine($"Nikoladze killed!");
                                Output();
                                b = true;
                                return b;
                            }
                        }
                    }
                }
            }
            return b;
        }
        public void MoveNotMain()
        {
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    if (place[i, j] == 'b')
                    {
                        char tmp = place[i, j];
                        place[i, j] = place[i, j + 1];
                        place[i, j + 1] = tmp;
                        if (j + 1 == place.GetLength(1) - 1)
                        {
                            place[i, j + 1] = 'd';
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else if (place[i, j] == 'd')
                    {
                        char tmp = place[i, j];
                        place[i, j] = place[i, j - 1];
                        place[i, j - 1] = tmp;
                        if (j - 1 == 0)
                        {
                            place[i, j - 1] = 'b';
                        }
                    }
                }
            }
        }
        public void MoveMain(char direction)
        {
            
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    if (place[i, j] == 'S')
                    {
                        if (direction == 'U')
                        {
                            place[i, j] = '.';
                            place[i - 1, j] = 'S';
                            return;
                        }
                        
                        if (direction == 'D')
                        {
                            place[i, j] = '.';
                            place[i + 1, j] = 'S';
                            return;
                        }
                        if (direction == 'L')
                        {
                            place[i, j] = '.';
                            place[i, j - 1] = 'S';
                            return;
                        }
                        if (direction == 'R')
                        {
                           
                            place[i, j] = '.';
                            place[i, j + 1] = 'S';
                            return;
                        }
                        if (direction == 'W')
                        {
                            return;
                        }
                    }
                }
            }

        }
    }
}
