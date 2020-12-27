using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;

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
        public int Endurance
        {
            get
            {
                return endurance;
            }
           private set
            {
                Validate(value, this.GetType().Name);
               endurance =value;
            }
        }
        public int Sprint
        {
            get
            {
                return sprint;
            }
            private set
            {
                Validate(value, this.GetType().Name);
                sprint = value;
            }
        }
        public int Dribble 
        { 
            get
            {
                return dribble;
            }
            private set
            {
                Validate(value, this.GetType().Name);
                dribble = value;
            }
        }

        public int Passing 
        {
            get
            {
                return passing;
            }
            private set
            {
                Validate(value, this.GetType().Name);
                passing = value;
            }
        }

        public int Shooting 
        {
            get
            {
                return shooting;
            }
            private set
            {
                Validate(value, this.GetType().Name);
                shooting = value;
            }
        }
       

        public double SkillLevel => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;

        private static void Validate(int value, string stats)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{stats} should be between 0 and 100.");
            }
        }
    }

}


