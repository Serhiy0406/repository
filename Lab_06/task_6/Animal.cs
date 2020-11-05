using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class Animal
    {
        private string name;
        private int age;
        private string gender;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid input!");
                }
                else { age = value; }
            }
        }
        public virtual string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Animal (string name, int age , string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual string ProduceSound()
        {
            return "Sound";
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{Name} {Age} {Gender}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
