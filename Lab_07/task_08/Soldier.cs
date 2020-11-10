using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class Soldier:ISoldier
    {
        private int id;
        private string firstname;
        private string lastname;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public Soldier(int id, string fn, string ln)
        {
            Id = id;
            Firstname = fn;
            Lastname = ln;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Name: {Firstname} {Lastname} Id: {Id} ");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
