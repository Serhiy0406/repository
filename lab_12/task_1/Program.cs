using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str == "End") break;
                dispatcher.Name = str;
            }
            Console.ReadKey();
        }
    }
}
