using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace task_05
{
    class Citizen: Society
    {
        private string id;
        private string birthdate;
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public Citizen(string name, int age, string id, string birthdate)
            :base(name, age)
        {
            Id = id;
            Birthdate = birthdate;
        }
        public override void BuyFood()
        {
            Food += 10;
        }
    }
}
