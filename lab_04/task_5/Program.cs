using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Gem gem = new Gem();
            Gold gold = new Gold();
            Cash cash = new Cash();
            Bag bag = new Bag();
            string[] s = Console.ReadLine().Split(' ');
            bag.AddLimit(int.Parse(s[0]));
            string[] s1 = Console.ReadLine().Split(' ');
            for(int i = 0; i < s1.Length; i += 2)
            {
                if (s1[i] == "Gold")
                {
                    if (bag.checkLimit(int.Parse(s1[i + 1])) == true)
                    {
                        bag.amount += int.Parse(s1[i + 1]);
                        gold.Add(s1[i], int.Parse(s1[i + 1]));
                    }
                }else if(s1[i].Length == 3)
                {
                    if (bag.checkLimit(int.Parse(s1[i + 1])) == true && cash.totalAmount + int.Parse(s1[i+1])<= gem.totalAmount)
                    {
                        bag.amount += int.Parse(s1[i + 1]);
                        cash.Add(s1[i], int.Parse(s1[i + 1]));
                    }
                }
                else
                {
                    if (bag.checkLimit(int.Parse(s1[i + 1])) == true && gem.totalAmount + int.Parse(s1[i+1]) <= gold.totalAmount)
                    {
                        bag.amount += int.Parse(s1[i + 1]);
                        gem.Add(s1[i], int.Parse(s1[i + 1]));
                    }
                }
            }
            if (gold.totalAmount > 0)
            {
                gold.Output();
            }
            if (gem.Type.Count != 0)
            {
                gem.Output();
            }
            if (cash.Type.Count != 0)
            {
                cash.Output();
            }
            Console.ReadKey();
        }
    }
}
