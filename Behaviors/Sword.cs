using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class Sword : IAttack
    {
         public void Attack(){
            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("Sword");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}