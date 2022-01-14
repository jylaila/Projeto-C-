namespace desafios.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nLevel: " + this.Level + "\nHero Type: " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name = this.Name + " Atacou com sua espada";
        }
    }

}