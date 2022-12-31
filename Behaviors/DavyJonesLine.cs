using pa2.Interfaces;
namespace pa2.Behaviors
{
    public class DavyJonesLine : ITalk
    {
        public void Talk(){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Davy Jones: Do you fear... death? Do you fear that dark abyss? All your deeds laid bare, all your sins punished?");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}