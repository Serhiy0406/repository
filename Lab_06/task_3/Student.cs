using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Student : Human
    {
        private string fnumber;
        public string Fnumber
        {
            get { return fnumber; }
            set
            {
                if(value.Length<5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                else { fnumber = value; }
            }
        }
        public Student(string firstname , string lastname, string fnumber)
            :base(firstname,lastname)
        {
            Fnumber = fnumber;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine($"Faculty number: {Fnumber}");
            return resultBuilder.ToString();
        }
    }
}
