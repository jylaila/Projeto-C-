using static System.Console;
using desafios.src.Entities;

namespace Desafios
{
    class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero(){Name = "Taylor", Level = 255, HeroType="Guerreiro"};
        Hero hero3 = new Wizard("Noah", 25, "Arqueiro");
        Wizard hero2 = new Wizard("Maga", 25, "Mago");

        WriteLine(hero.Attack());
        WriteLine(hero2.Attack(5));    
        WriteLine(hero3.Attack());
    }
}
    
}