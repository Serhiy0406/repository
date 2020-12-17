using System;
using System.Reflection;
namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("P02_BlackBoxInteger.BlackBoxInteger", false, true);
            var example = Activator.CreateInstance(type, true);
            while (true)
            {
                string[] str = Console.ReadLine().Split('_');
                if (str[0] == "END") { break; }
                MethodInfo method = type.GetMethod(str[0], BindingFlags.NonPublic | BindingFlags.Instance);
                method.Invoke(example, new object[] { int.Parse(str[1]) });
                var result = (int)type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(example);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
