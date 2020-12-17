using System;
using System.Reflection;
namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("P01_HarvestingFields.HarvestingFields", false/*throwOnError*/, true/*ignoreCase*/);
            for(int i = 0; i < 100; i++)
            {
                string switchCase = Console.ReadLine();
                if(switchCase == "HARVEST") { break; }
                switch (switchCase)
                {
                    case "private":
                        foreach(FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            }
                                
                        }
                        break;
                    case "protected":
                        foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                        {
                            if (field.IsPrivate == false)
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "public":
                        foreach (FieldInfo field in type.GetFields())
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "all":
                        foreach (FieldInfo field in type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
                        {
                            if(field.IsPublic)
                                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            if (field.IsPrivate)
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            if (field.IsPrivate == false && field.IsPublic == false)
                                Console.WriteLine($"potected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
