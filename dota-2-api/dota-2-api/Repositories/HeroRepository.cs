using dota_2_api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dota_2_api.Models.Dota2.Interfaces;
using dota_2_api.Models.Dota2;

namespace dota_2_api.Repositories
{
    public class HeroRepository : IHeroRepository
    {

        private static readonly Lazy<IReadOnlyCollection<IHero>> heros = new Lazy<IReadOnlyCollection<IHero>>(() => new List<IHero>
        {
                new Hero(
                    name: "Axe", 
                    type: HeroType.Strength,
                    initialStrength: 25,
                    initialAgility: 20,
                    initialIntelligence: 18,
                    strengthGainPerLevel: 2.5,
                    agilityGainPerLevel: 2.2,
                    intelligenceGainPerLevel: 1.6
                    ),
                new Hero("Juggernaut", HeroType.Agility,
                    initialStrength: 20,
                    initialAgility: 26,
                    initialIntelligence: 14,
                    strengthGainPerLevel: 1.9,
                    agilityGainPerLevel: 2.4,
                    intelligenceGainPerLevel: 1.4),
                new Hero("Disruptor", HeroType.Intelligence,
                    initialStrength: 19,
                    initialAgility: 15,
                    initialIntelligence: 22,
                    strengthGainPerLevel: 1.9,
                    agilityGainPerLevel: 1.4,
                    intelligenceGainPerLevel: 2.5)
            });

        public IReadOnlyCollection<IHero> Read()
        {
            return heros.Value;
        }

        public IHero ReadByName(string name)
        {
            return heros.Value.SingleOrDefault(h => String.Equals(h.Name, name, StringComparison.OrdinalIgnoreCase));
        }
    }
}