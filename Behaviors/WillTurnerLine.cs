using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class WillTurnerLine : ITalk
    {
        public void Talk(){
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("Will Turner: My name is Will Turner...and you, my friend, are finished!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}