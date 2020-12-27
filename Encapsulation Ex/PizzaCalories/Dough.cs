using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
   public class Dough
    {
        private Dictionary<string, double> type = new Dictionary<string, double> {
            {"White", 1.5 },
            {"Wholegrain", 1 }
            
        };
        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double> 
        { 
            {"Crispy", 0.9 },
            {"Chewy", 1.1 },
            {"Homemade", 1 }
        };

        private string flourType;
        private const int weightPerGram = 2;
        public Dough(string flourType)
        {
            this.FlourType = flourType;
        }
        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (!type.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");           
                }

                flourType = value;
                
            }
        }
        public string Technique
        { get; private set; }
        public Dough()
        {

        }

        public double CaloriesPerGram { get; }
        public double CalculateCalories()
        {
            //2* grams * properties.Value * properties.Value;
            return 0; 
        }

    }
}
