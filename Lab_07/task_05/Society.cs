using System;
using System.Collections.Generic;
using System.Text;

namespace task_05
{
    class Society: IChecking
    {
        private string name;
        private string id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id 
        {
            get { return id; }
            set { id = value; }
        }
        public Society(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public bool Check(string part)
        {
            return Id.EndsWith(part);
        }
    }
}
