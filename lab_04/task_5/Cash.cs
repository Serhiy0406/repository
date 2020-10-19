using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Cash : Treasure
    {
        public void Output()
        {
            Console.WriteLine($"<Cash> ${totalAmount}");
            for (int i = 0; i < Type.Count; i++)
            {
                for (int j = 0; j < Type.Count; j++)
                {
                    if (string.Compare(Type[i], Type[j]) > 0)
                    {
                        string tmp = Type[i];
                        Type[i] = Type[j];
                        Type[j] = tmp;
                        int tmp2 = Amount[i];
                        Amount[i] = Amount[j];
                        Amount[j] = tmp2;
                    }
                }
            }
            for (int i = 0; i < Type.Count; i++)
            {
                Console.WriteLine($"##{Type[i]} - {Amount[i]}");
            }
        }
    }
}
