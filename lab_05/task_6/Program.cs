using System;
using System.Collections.Generic;
namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> listOfTeams = new List<Team>();
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    string[] s = Console.ReadLine().Split(";");
                    if (s[0] == "END")
                    {
                        break;
                    }
                    else if(s[0] == "Team")
                    {
                        listOfTeams.Add(new Team(s[1]));
                    }
                    else if (s[0] == "Add")
                    {
                        bool b = false;
                        for(int j = 0; j < listOfTeams.Count; j++)
                        {
                            if (listOfTeams[j].Name == s[1])
                            {
                                listOfTeams[j].AddPlayer(new Player(s[2], new Stats(int.Parse(s[3]), int.Parse(s[4]), int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]))));
                                b = true;
                                break;
                            }
                        }
                        if (b == false) { throw new Exception($"Team {s[1]} does not exist."); }
                    }
                    else if (s[0] == "Remove")
                    {
                        for (int j = 0; j < listOfTeams.Count; j++)
                        {
                            if (listOfTeams[j].Name == s[1])
                            {
                                listOfTeams[j].RemovePlayer(s[2]);
                                break;
                            }
                        }
                    }
                    else if (s[0] == "Rating")
                    {
                        bool b = false;
                        for (int j = 0; j < listOfTeams.Count; j++)
                        {
                            if (listOfTeams[j].Name == s[1])
                            {
                                listOfTeams[j].forRating();
                                Console.WriteLine($"{listOfTeams[j].Name} - {listOfTeams[j].Rating:0}");
                                b = true;
                                break;
                            }
                        }
                        if (b == false) { throw new Exception($"Team {s[1]} does not exist."); }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
