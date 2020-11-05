using System;
using System.Collections.Generic;
using System.Text;
using task_4.forSongExeption;

namespace task_4.forSongLengthExeption
{
    class InvalidSongMinutesExeption: InvalidSongLengthExeption
    {
        public InvalidSongMinutesExeption(string message)
        : base(message)
        {
        }
    }
}
