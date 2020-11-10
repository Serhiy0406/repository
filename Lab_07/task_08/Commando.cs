using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using task_08.Interfaces;

namespace task_08
{
    class Commando:SpecialisedSoldier, ICommando
    {
        public List<Mission> listMission { get; set; } = new List<Mission>();
        public Commando(int id, string fn, string ln, float salary, string corps)
            : base(id, fn, ln, salary, corps)
        {
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.Append(base.ToString())
                .Append("Mission:");
            for (int i = 0; i < listMission.Count; i++)
            {
                resultBuilder.AppendLine($"   Code Name: {listMission[i].Codename} State: {listMission[i].State}");
            }
            return resultBuilder.ToString();
        }
        public void CompleteMisson(string code, string state)
        {
            listMission.Add(new Mission(code, state));
        }
    }
}
