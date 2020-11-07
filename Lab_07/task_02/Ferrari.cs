using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace task_03
{
    class Ferrari : IMovable1
    {
        private string driver;
        private const string model = "488 - Spider";
        public string Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        public string Model
        {
            get { return model; }
        }
        public Ferrari(string driver)
        {
            Driver = driver;
        }
        public string Break()
        {
            return "Brakes!";
        }
        public string Gas()
        {
            return "Zadu6avam sA!";
        }
    }
}
