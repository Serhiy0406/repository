using System;
using System.Collections.Generic;
using System.Text;

namespace task_6
{
    class Team
    {
        private string name;
        private float rating=0;
        private List<Player> listOfPlayers = new List<Player>();
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
        public float Rating 
        {
            get { return rating; }
        }
        public void forRating()
        {
            for(int i = 0; i < listOfPlayers.Count; i++)
            {
                rating += listOfPlayers[i].forSkill();
            }
            rating /= listOfPlayers.Count;
        }
        public void AddPlayer(Player player)
        {
            listOfPlayers.Add(player);
        }
        public void RemovePlayer(string name)
        {
            bool b = false;
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                if (listOfPlayers[i].Name == name)
                {
                    listOfPlayers.RemoveAt(i);
                    b = true;
                    break;
                }
            }
            if (b==false)
            {
                throw new Exception($"Player {name} is not in {Name} team.");
            }
        }
        public Team(string name)
        {
            Name = name;
        }
    }
}
