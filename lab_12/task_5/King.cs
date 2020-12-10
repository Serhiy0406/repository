using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    public delegate void Notify();
    class King
    {
        public event Notify Attacked;
        public string Name { get; set; }
        public King(string name)
        {
            Name = name;
        }
        public void StartAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            OnAttacked();
        }
        protected virtual void OnAttacked()
        {
            Attacked?.Invoke();
        }
    }
}
