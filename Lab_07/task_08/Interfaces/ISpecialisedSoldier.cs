using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface ISpecialisedSoldier: IPrivate
    {
        public string Corps { get; set; }
    }
}
