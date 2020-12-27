using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
  public class Team
    {
       private string name;
       private readonly ICollection<Player> players; //ne mogat da se vijdat igrachite
        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
           
        }

        public string Name
        {
            get 
            {
                return name; 
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Rating => this.players.Count > 0 ? (int)Math.Round(this.players.Average(p=>p.SkillLevel)) : 0;

        public void AddPlayer(Player player)
        {
         
            players.Add(player);
        }

        public void RemovePlayer(string teamName, string playerName)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
            }
            else
            {
                players.Remove(playerToRemove);
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}"; 
        }
    }
}
