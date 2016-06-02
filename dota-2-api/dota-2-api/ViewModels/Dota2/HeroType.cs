using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelHeroType = dota_2_api.Models.Dota2.HeroType;

namespace dota_2_api.ViewModels.Dota2
{
    /// <summary>
    /// The type of hero.
    /// </summary>
    public enum HeroType
    {
        /// <summary>
        /// Default value. Do not use.
        /// </summary>
        None = ModelHeroType.None,
        /// <summary>
        /// Heros who's damage increases with strength
        /// </summary>
        Strength = ModelHeroType.Strength,
        /// <summary>
        /// Heros who's damage increases with agility
        /// </summary>
        Agility = ModelHeroType.Agility,
        /// <summary>
        /// Heros who's damage increases with intelligence
        /// </summary>
        Intelligence = ModelHeroType.Intelligence
    }
}