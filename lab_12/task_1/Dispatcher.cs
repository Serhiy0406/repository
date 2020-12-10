using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace task_1
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get { return name; }

            set
            {
                OnNameChange(new NameChangeEventArgs(value));
                name = value;
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
