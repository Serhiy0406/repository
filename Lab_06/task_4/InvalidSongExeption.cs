using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class InvalidSongExeption : Exception
    {
        public InvalidSongExeption(string message)
            :base(message)
        {
        }
    }
}
