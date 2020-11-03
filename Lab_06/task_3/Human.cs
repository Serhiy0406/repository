using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Human
    {
        private string firstname;
        private string lastname;
        public  string Firstname 
        {
            get { return firstname; }
            set
            {
                if (Char.IsUpper(value[0]))
                {
                    if (value.Length > 3)
                    {
                        firstname = value;
                    }
                    else { throw new ArgumentException($"Expected length at least 4 symbols! Argument: {value}"); }
                }
                else { throw new ArgumentException($"Expected upper case letter! Argument: {value}"); }
            }
        }
        public  string Lastname
        {
            get { return lastname; }
            set
            {
                if (Char.IsUpper(value[0]))
                {
                    if (value.Length > 3)
                    {
                        lastname = value;
                    }
                    else { throw new ArgumentException($"Expected length at least 4 symbols! Argument: {value}"); }
                }
                else { throw new ArgumentException($"Expected upper case letter! Argument: {value}"); }
            }
        }
        public Human(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.Firstname}")
            .AppendLine($"Last Name: {this.Lastname}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
