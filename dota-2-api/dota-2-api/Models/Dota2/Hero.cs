using dota_2_api.Models.Dota2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.Models.Dota2
{
    public class Hero : HeroBase, IHero
    {
        public Hero(
            string name, 
            HeroType type, 
            int initialStrength,
            int initialAgility,
            int initialIntelligence,
            double strengthGainPerLevel,
            double agilityGainPerLevel,
            double intelligenceGainPerLevel
            )

        {
            Name = name;
            Type = type;
            InitialStrength = InitialStrength;
            InitialAgility = initialAgility;
            InitialIntelligence = initialIntelligence;
            StrengthGainPerLevel = strengthGainPerLevel;
            AgilityGainPerLevel = agilityGainPerLevel;
            IntelligenceGainPerLevel = intelligenceGainPerLevel;
        }

        public string Name { get; private set; }

        public HeroType Type { get; private set; }

        public int InitialAgility { get; private set; }

        public int InitialIntelligence { get; private set; }
        
        public int InitialStrength { get; private set; }

        public double AgilityGainPerLevel { get; private set; }

        public double IntelligenceGainPerLevel { get; private set; }

        public double StrengthGainPerLevel { get; private set; }

        
    }
}