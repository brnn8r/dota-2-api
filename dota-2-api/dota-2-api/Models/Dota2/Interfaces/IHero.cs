namespace dota_2_api.Models.Dota2.Interfaces
{
    public interface IHero
    {
        string Name { get; }        
        HeroType Type { get; }

        int InitialHealth { get; }
        int InitialMana { get; }

        int InitialStrength { get; }
        double StrengthGainPerLevel { get; }

        int InitialAgility { get; }
        double AgilityGainPerLevel { get; }

        int InitialIntelligence { get; }
        double IntelligenceGainPerLevel { get; }

    }
}
