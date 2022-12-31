using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class Distract : IAttack
    {
         public void Attack(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Distract");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}