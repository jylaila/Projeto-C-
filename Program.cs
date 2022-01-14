using static System.Console;
using desafios.src.Entities;

namespace Desafios
{
    class Program
{
    static void Main(string[] args)
    {
        Knight hero = new Knight(){Name = "Taylor", Level = 255, HeroType="Guerreiro"};
        Wizard hero3 = new Wizard("Noah", 25, "Arqueiro");
        Wizard hero2 = new Wizard("Maga", 25, "Mago");

        WriteLine(hero.Attack());  
        WriteLine(hero2.Attack(10));   
        WriteLine(hero3.Attack());
    }
}
    
}