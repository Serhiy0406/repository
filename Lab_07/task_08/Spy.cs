using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class Spy:Soldier, ISpy
    {
        private int codenumber;
        public int Codenumber
        {
            get { return codenumber; }
            set { codenumber = value; }
        }
        public Spy(int id, string fn, string ln, int codenumber)
            :base(id,fn,ln)
        {
            Codenumber = codenumber;
        }
    }
}
