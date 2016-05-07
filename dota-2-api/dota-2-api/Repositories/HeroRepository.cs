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
                new Hero("Axe", HeroType.Stength),
                new Hero("Juggernaut", HeroType.Agility),
                new Hero("Disruptor", HeroType.Intelligence)
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