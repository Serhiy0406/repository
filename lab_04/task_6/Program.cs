using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            string s = Console.ReadLine();
            room.Create(int.Parse(s));
            for(int i = 0; i < int.Parse(s); i++)
            {
                string s1 = Console.ReadLine();
                room.Fill(s1,i);
            }
            string s2 = Console.ReadLine();
            for (int i = 0; i < s2.Length; i++)
            {
                room.MoveNotMain();
                room.MoveMain(s2[i]);
                bool b = room.Check();
                if (b == true)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
