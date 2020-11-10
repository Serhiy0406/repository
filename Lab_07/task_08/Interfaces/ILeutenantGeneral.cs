using System;
using System.Collections.Generic;
using System.Text;

namespace task_08.Interfaces
{
    interface ILeutenantGeneral:IPrivate
    {
        List<Privates> listOfPrivates { get; set; }
    }
}
