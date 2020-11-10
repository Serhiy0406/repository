using System;
using System.Collections.Generic;

namespace task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            List<Privates> listOfPrivates = new List<Privates>();
            string[] s;
            string switchcase;
            do
            {
                s = Console.ReadLine().Split(' ');
                switchcase = s[0];
                switch (switchcase) 
                {
                    case "Private":
                        Privates privates = new Privates(int.Parse(s[1]), s[2], s[3], float.Parse(s[4]));
                        listOfPrivates.Add(privates);
                        soldiers.Add(privates);
                        break;
                    case "Spy":
                        Spy spy = new Spy(int.Parse(s[1]), s[2], s[3], int.Parse(s[4]));
                        soldiers.Add(spy);
                        break;
                    case "LeutenantGeneral":
                        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(int.Parse(s[1]), s[2], s[3], float.Parse(s[4]));
                        for(int j = 5; j< s.Length; j++)
                        {
                            foreach(var k in listOfPrivates)
                            {
                                if (k.Id == int.Parse(s[j]))
                                {
                                    leutenantGeneral.listOfPrivates.Add(k);
                                }
                            }
                        }
                        soldiers.Add(leutenantGeneral);
                        break;
                    case "Engineer":
                        Engineer engineer = new Engineer(int.Parse(s[1]), s[2], s[3], float.Parse(s[4]),s[5]);
                        for(int i = 6; i < s.Length; i+=2)
                        {
                            engineer.listRepair.Add(new Repair(s[i],int.Parse(s[i+1])));
                        }
                        soldiers.Add(engineer);
                        break;
                    case "Commando":
                        Commando commando = new Commando(int.Parse(s[1]), s[2], s[3], float.Parse(s[4]), s[5]);
                        for (int i = 6; i < s.Length; i += 2)
                        {
                            commando.CompleteMisson(s[i],s[i+1]);
                        }
                        soldiers.Add(commando);
                        break;
                }
            } while (s[0]!="End");
            foreach(var i in soldiers)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
