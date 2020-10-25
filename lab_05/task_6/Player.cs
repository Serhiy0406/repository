using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class Player
    {
        private string name;
        private Stats stats;
        private float skillLevel=0;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public Stats STats 
        {
            get { return stats; }
            set { stats = value; }
        }
        public float forSkill()
        {
            skillLevel += STats.Dribble + STats.Endurance + STats.Passing + STats.Shooting + STats.Sprint;
            skillLevel /= 5;
            float result = skillLevel;
            return result;
        }
        public Player(string name, Stats stats)
        {
            Name = name;
            STats = stats;
        }
    }
}
