using System;
using System.Collections.Generic;
using System.Text;

namespace task_4.forSongExeption
{
    class InvalidSongNameExeption:InvalidSongExeption
    {
        public InvalidSongNameExeption(string message)
            :base(message)
        {
        }
    }
}
