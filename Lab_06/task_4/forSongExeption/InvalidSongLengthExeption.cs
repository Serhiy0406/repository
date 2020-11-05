using System;
using System.Collections.Generic;
using System.Text;

namespace task_4.forSongExeption
{
    class InvalidSongLengthExeption : InvalidSongExeption
    {
        public InvalidSongLengthExeption(string message)
            : base(message)
        {
        }
    }
}
