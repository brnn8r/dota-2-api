using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.ViewModels.Dota2
{
    public class HeroDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int InitialHealth { get; set; }
        public int InitialMana { get; set; }
        public int InitialStrength { get; set; }
        public int InitialAgility { get; set; }
        public int InitialIntelligence { get; set; }
        public double StrengthGainPerLevel { get; set; }
        public double AgilityGainPerLevel { get; set; }
        public double IntelligenceGainPerLevel { get; set; }
    }
}