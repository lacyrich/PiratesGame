using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class CannonFire : IAttack
    {
        public void Attack(){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Cannon Fire");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}