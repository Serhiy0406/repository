using System;
using System.Collections.Generic;
using System.Text;

namespace task_08
{
    class Mission
    {
        private string codename;
        private string state;
        public string Codename
        {
            get { return codename; }
            set { codename = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public Mission(string codename, string state)
        {
            Codename = codename;
            State = state;
        }
    }
}
