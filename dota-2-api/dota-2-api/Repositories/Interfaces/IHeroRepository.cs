using dota_2_api.Models.Dota2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota_2_api.Repositories.Interfaces
{
    public interface IHeroRepository
    {
        /// <summary>
        /// Get all heros
        /// </summary>
        /// <returns>A list of all heros</returns>
        IReadOnlyCollection<IHero> Read();
    }
}
