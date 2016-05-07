using dota_2_api.Models.Dota2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dota_2_api.Models.Dota2
{
    public class Hero : IHero
    {
        public Hero(string name, HeroType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; private set; }
        

        public HeroType Type { get; private set; }
    }
}