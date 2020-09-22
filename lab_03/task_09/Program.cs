using System;

namespace task_09
{
    class Program
    {

        public class Rectangle 
        {
            string id;
            int width;
            int height;
            int[] point=new int[2];
            public Rectangle(string id, int width, int height, int point1, int point2)
            {
                this.id = id;
                this.width = width;
                this.height = height;
                point[0] = point1;
                point[1] = point2;
            }
            public static bool Checkin(string id1, string id2, Rectangle[] rec, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (rec[i].id == id1)
                    {
                        for(int j = 0; j < n; j++)
                        {
                            if (rec[j].id == id2)
                            {
                                if((rec[i].point[0]==rec[j].point[0] && rec[i].point[1] == rec[j].point[1]) ||
                                    ((rec[i].point[0] > rec[j].point[0] && rec[i].point[0] < rec[j].point[0]+rec[j].width) && (rec[i].point[1] < rec[j].point[1] && rec[i].point[1] > rec[j].point[1] - rec[j].height)) ||
                                    ((rec[j].point[0] > rec[i].point[0] && rec[j].point[0] < rec[i].point[0] + rec[i].width) && (rec[j].point[1] < rec[i].point[1] && rec[j].point[1] > rec[i].point[1] - rec[i].height)))
                                {
                                    return true;
                                }
                                else { return false; }
                            }
                        }
                    }
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool b;
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]);
            Rectangle[] rec = new Rectangle[n];
            int m = Convert.ToInt32(s[1]);
            for(int i = 0; i < n; i++)
            {
                string[] p = Console.ReadLine().Split(' '); 
                rec[i] = new Rectangle(p[0],Convert.ToInt32(p[1]), Convert.ToInt32(p[2]), Convert.ToInt32(p[3]), Convert.ToInt32(p[4]));
            }
            for(int i = 0; i < m; i++)
            {
                string[] l = Console.ReadLine().Split(' ');
                b = Rectangle.Checkin(l[0], l[1], rec, n);
                Console.WriteLine($"{b}");
            }
            
            Console.ReadKey();
        }
    }
}
