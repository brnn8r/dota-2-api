using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.ViewModels.Dota2
{
    public class Hero
    {
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public HeroType Type { get; set; }
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