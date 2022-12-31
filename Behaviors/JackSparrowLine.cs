using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class JackSparrowLine : ITalk
    {
        public void Talk(){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Jack Sparrow: I've got a jar of dirt!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}