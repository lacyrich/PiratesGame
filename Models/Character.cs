using pa2.Interfaces;
using pa2.Behaviors;
namespace pa2.Models
{
    public class Character
    {
        public string CharacterName {get; set;}
        public int MaxPower {get; set;}
        public double Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensivePower {get;set;}
        public IAttack AttackBehavior {get; set;}
        public IDefend DefendBehavior {get; set;}
        public ITalk SayLine {get; set;}
        public string AttackName {get; set;}
        public string DefendName {get; set;}
        Random rnd = new Random();
        public Character(){
            CharacterName = "";
            MaxPower = rnd.Next(1,100);
            Health = 100;
            AttackStrength = rnd.Next(1, MaxPower);
            DefensivePower = rnd.Next(1, MaxPower);
            DefendBehavior = new Block();
            DefendName = "Block";
        }

        public void DisplayStats(){
            System.Console.WriteLine($"Name: {CharacterName} \nMax Power: {MaxPower} \t Health: {Health}");
            System.Console.WriteLine($"Attack Strength: {AttackStrength} \t Defensive Power: {DefensivePower}");
            System.Console.WriteLine($"Attack Behavior: {AttackName} \t Defend Behavior: {DefendName}");
        }
    }
}