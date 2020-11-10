using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace task_08.Interfaces
{
    interface ISoldier
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
