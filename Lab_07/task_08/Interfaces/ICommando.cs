using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface ICommando:ISpecialisedSoldier
    {
        List<Mission> listMission { get; set; }
        public void CompleteMisson(string code, string state);
    }
}
