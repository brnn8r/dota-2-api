namespace dota_2_api.Models.Dota2
{
    public abstract class HeroBase
    {        
        public int InitialHealth { get { return 200; } }
        public int InitialMana { get { return 50; } }
    }
}