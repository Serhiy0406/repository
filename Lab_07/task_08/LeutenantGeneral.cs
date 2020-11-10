    using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class LeutenantGeneral:Privates,ILeutenantGeneral
    {
        public List<Privates> listOfPrivates { get; set; } = new List<Privates>();
        public LeutenantGeneral(int id, string fn, string ln, float salary)
            : base(id, fn, ln,salary)
        {
        }
        public override string ToString()
        {

            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine("Privates:");
            foreach(var i in listOfPrivates)
            {
               resultBuilder.AppendLine($"   {i.ToString()}");
            }      
            return resultBuilder.ToString();
        }
    }
}
