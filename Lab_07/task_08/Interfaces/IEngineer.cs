using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface IEngineer:ISpecialisedSoldier
    {
        List<Repair> listRepair { get; set; }
    }
}
