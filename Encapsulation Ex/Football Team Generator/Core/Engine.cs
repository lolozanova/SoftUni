using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        private ICollection<Team> teams;

        public Engine()
        {

            this.teams = new List<Team>();
        }

        public void Run()
        {
           
            Team team = null;
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split(';');

                if (command[0] == "Team")
                {
                    try
                    {
                        team = new Team(command[1]);
                        teams.Add(team);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine (ex.Message);
                    }

                }
                else if (command[0] == "Add")
                {
                    string teamName = command[1];
                    string playerName = command[2];
                    int endurance = int.Parse(command[3]);
                    int sprint = int.Parse(command[4]);
                    int dribble = int.Parse(command[5]);
                    int passing = int.Parse(command[6]);
                    int shooting = int.Parse(command[7]);

                    ValidateTeam(teamName);

                    Player currPlayer = null;

                    try
                    {
                         currPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message); ;
                    }

                        team = teams.First(x => x.Name == teamName);
                        team.AddPlayer(currPlayer);
                    
                }
                else if (command[0] == "Remove")
                {
                    string teamName = command[1];
                    string playerName = command[2];

                    ValidateTeam(teamName);

                    team = teams.First(x => x.Name == teamName);
                    try
                    {
                        team.RemovePlayer(teamName, playerName);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message); 
                    }
                    

                }

                else if (command[0] == "Rating")
                {
                    string teamName = command[1];
                    ValidateTeam(teamName);
                    Team currTeam = teams.First(t=>t.Name == teamName);
                    Console.WriteLine(currTeam);
                }

                input = Console.ReadLine();
            }
        }

        private void ValidateTeam(string teamName)
        {
            if (!teams.Any(x => x.Name == teamName))
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }
        }
            
    }
}
