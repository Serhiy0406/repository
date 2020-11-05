using System;
using System.Collections.Generic;
using System.Text;

namespace task_4.forSongExeption
{
    class InvalidArtistNameExeption: InvalidSongExeption
    {
        public InvalidArtistNameExeption(string message)
            : base(message)
        {
        }
    }
}
