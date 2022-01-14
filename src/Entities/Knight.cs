namespace desafios.src.Entities
{
    public class Knight:Hero
    {
         public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Knight(){}
    }
}