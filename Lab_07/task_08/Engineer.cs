using System;
using System.Collections.Generic;
using System.Text;
using task_08.Interfaces;

namespace task_08
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> listRepair { get; set; } = new List<Repair>();
        public Engineer(int id, string fn, string ln, float salary,string corps)
            : base(id, fn, ln, salary,corps)
        {
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine("Repairs:");
            for (int i = 0; i < listRepair.Count; i++)
            {
                resultBuilder.AppendLine($"   Part Name: {listRepair[i].Partname} Worked: {listRepair[i].Hours}");
            }
            return resultBuilder.ToString();
        }
    }
}
