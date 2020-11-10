using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class SpecialisedSoldier:Privates, ISpecialisedSoldier
    {
        private string corps;
        public string Corps
        {
            get { return corps; }
            set { corps = value; }
        }
        public SpecialisedSoldier(int id, string fn, string ln, float salary, string corps)
            : base(id, fn, ln, salary)
        {
            Corps = corps;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine($"Corps: {Corps}");
            return resultBuilder.ToString();
        }
    }
}
