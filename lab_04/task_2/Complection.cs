using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    abstract class Complection
    {
        public List<Car> cars = new List<Car>();
        public List<Engine> engines = new List<Engine>();
        public abstract void printOut();
    }
}
