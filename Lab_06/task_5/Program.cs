using System;
using task_5.FoodClasses;
using task_5.MoodClasses;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int totalpoints = 0;
                string a = Console.ReadLine();
                string[] s = a.Split(' ');
                if (a.Length > 1000)
                {
                    throw new Exception("The characters in the input string will be no more than: 1000");
                }
                if(s.Length<1 || s.Length > 100)
                {
                    throw new Exception("The food count would be in the range [1…100].");
                }
                string caseSwitch;
                foreach (var p in s)
                {
                    caseSwitch = p;
                    switch (caseSwitch) 
                    {
                        case "Apple":
                          Apple apple = new Apple(p);
                            totalpoints += apple.Point;
                            break;
                        case "Cram":
                            Cram cram = new Cram(p);
                            totalpoints += cram.Point;
                            break;
                        case "HoneyCake":
                            HoneyCake honeyCake = new HoneyCake(p);
                            totalpoints += honeyCake.Point;
                            break;
                        case "Lembas":
                            Lembas lembas = new Lembas(p);
                            totalpoints += lembas.Point;
                            break;
                        case "Melon":
                            Melon melon = new Melon(p);
                            totalpoints += melon.Point;
                            break;
                        case "Mushrooms":
                            Mushrooms mushrooms = new Mushrooms(p);
                            totalpoints += mushrooms.Point;
                            break;
                        default:
                            EverithingElse everithingElse = new EverithingElse(p);
                            totalpoints += everithingElse.Point;
                            break;
                    }
                }
                if (totalpoints < -5)
                {
                    Angry angry = new Angry();
                    Console.WriteLine(totalpoints);
                    angry.Output();
                }else if (totalpoints >= 1 && totalpoints <= 15)
                {
                    Happy happy = new Happy();
                    Console.WriteLine(totalpoints);
                    happy.Output();
                }
                else if(totalpoints >= -5 && totalpoints<=0)
                {
                    Sad sad = new Sad();
                    Console.WriteLine(totalpoints);
                    sad.Output();
                }else if (totalpoints > 15)
                {
                    JavaScript javaScript = new JavaScript();
                    Console.WriteLine(totalpoints);
                    javaScript.Output();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            
            Console.ReadKey();
        }
    }
}
