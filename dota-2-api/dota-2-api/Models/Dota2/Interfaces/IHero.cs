using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota_2_api.Models.Dota2.Interfaces
{
    public interface IHero
    {
        string Name { get; }
        HeroType Type { get; }

    }
}
