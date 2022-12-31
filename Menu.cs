namespace pa2
{
    public class Menu
    {
        private void DisplayMainMenu(){
            System.Console.WriteLine("1. Play 2-player game");
            System.Console.WriteLine("2. Exit");
        }

        public string GetMainMenuChoice(){
            DisplayMainMenu();
            System.Console.WriteLine("Enter Menu Choice");
            return Console.ReadLine();
        }

        public void DisplayCharactersMenu(){
            System.Console.WriteLine("Enter the number next to the character to view their stats");
            System.Console.WriteLine("1. Davy Jones");
            System.Console.WriteLine("2. Jack Sparrow");
            System.Console.WriteLine("3. Will Turner");
        }
    }
}