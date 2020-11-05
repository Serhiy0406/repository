using System;
using System.Collections.Generic;
using System.Text;
using task_4.forSongExeption;

namespace task_4.forSongLengthExeption
{
    class InvalidSongSecondsExeption: InvalidSongLengthExeption
    {
        public InvalidSongSecondsExeption(string message)
        :base (message)
        {
        }
    }
}
