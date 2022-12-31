using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class Block : IDefend
    {
        public void Defend(){
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Blocks");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}