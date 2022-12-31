using pa2;
using pa2.Models;
using pa2.Behaviors;
using pa2.Interfaces;

Menu menu = new Menu();
Player player1 = new Player(){PlayerNum = 1};
Player player2 = new Player(){PlayerNum = 2}; 


Console.ForegroundColor = ConsoleColor.DarkCyan;
System.Console.WriteLine("Welcome to Pirates of the Carribbean World's End: Battle of Calypso's Maelstrom");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();
Console.Clear();

string userInput = menu.GetMainMenuChoice();
while(userInput != "2" && player1.PlayerCharacter.Health == 100 && player2.PlayerCharacter.Health == 100){
    RouteEm(userInput);
}

void RouteEm(string userInput){
    switch (userInput){
        case "1":
            TwoPlayerMode();
            break;
        default:
            System.Console.WriteLine("Bad entry");
            break;
    }
}
        int attackingPlayer = 1;
        double damageDealt = 0;
        void TwoPlayerMode(){
            CharacterSelection();
            System.Console.WriteLine(player1.PlayerCharacter.Health);
            while(player1.PlayerCharacter.Health > 0 && player2.PlayerCharacter.Health > 0){
                Gameplay();
            }
            System.Console.WriteLine("The battle is over\nPress any key to continue...");
            Console.Clear();
            if(player1.PlayerCharacter.Health > player2.PlayerCharacter.Health ){
                System.Console.WriteLine($"The winner of the battle is {player1.PlayerName} as {player1.PlayerCharacter.CharacterName}");
                System.Console.WriteLine($"The loser of the battle is {player2.PlayerName} as {player2.PlayerCharacter.CharacterName}");
            }
            else{
                 System.Console.WriteLine($"The winner of the battle is {player2.PlayerName} as {player2.PlayerCharacter.CharacterName}");
                System.Console.WriteLine($"The loser of the battle is {player1.PlayerName} as {player1.PlayerCharacter.CharacterName}");
            }
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        void CharacterSelection(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("Player 1: Please enter your name");
            player1.PlayerName = Console.ReadLine();
            player1.ChooseCharacter(); 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Player 2: Please enter your name");
            player2.PlayerName = Console.ReadLine(); 
            player2.ChooseCharacter();   
            Console.ForegroundColor = ConsoleColor.White;
        }

        void Gameplay(){
            GoesFirst();
            SeeIfBonus();
            PlayerAttacks();
        }

        void GoesFirst(){
            Random rnd = new Random();
            int playsFirst = rnd.Next(0,2);
            if(playsFirst == 1){
                Console.Clear();
                System.Console.WriteLine("\nPlayer 1 goes first");
                attackingPlayer = 1;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("\nPlayer 2 goes first");
                attackingPlayer = 2;
            }
        }

        void SeeIfBonus(){
            if(player1.PlayerCharacter.CharacterName == "Jack Sparrow" && player2.PlayerCharacter.CharacterName == "Will Turner"){
                player1.Bonus = 1.2;
            }
            else if(player1.PlayerCharacter.CharacterName == "Will Turner" && player2.PlayerCharacter.CharacterName == "Davy Jones"){
                player1.Bonus = 1.2;
            }
            else if(player1.PlayerCharacter.CharacterName  == "Davy Jones" && player2.PlayerCharacter.CharacterName  == "Jack Sparrow"){
                player1.Bonus = 1.2;
            }
            else if(player2.PlayerCharacter.CharacterName  == "Jack Sparrow" && player1.PlayerCharacter.CharacterName  == "Will Turner"){
                player2.Bonus = 1.2;
            }
            else if(player2.PlayerCharacter.CharacterName  == "Will Turner" && player1.PlayerCharacter.CharacterName  == "Davy Jones"){
                player2.Bonus = 1.2;
            }
            else if(player2.PlayerCharacter.CharacterName == "Davy Jones" && player1.PlayerCharacter.CharacterName == "Jack Sparrow"){
                player2.Bonus = 1.2;
            }
            else{
                player1.Bonus = 1;
                player2.Bonus = 1;
            }
        }

        void PlayerAttacks(){
            if(attackingPlayer == 1){
                System.Console.WriteLine("\nPlayer 1: Press any key to attack");
                Console.ReadKey();
                Console.Clear();
                player1.PlayerCharacter.AttackBehavior.Attack();
                System.Console.WriteLine("\nPlayer 2: Press any key to defend");
                Console.ReadKey();
                Console.Clear();
                player2.PlayerCharacter.DefendBehavior.Defend();
                damageDealt = (player1.PlayerCharacter.AttackStrength - player2.PlayerCharacter.DefensivePower) * (player1.Bonus);
                if(damageDealt <= 0){
                    damageDealt = 1;
                }
                else{
                    damageDealt = damageDealt;
                }
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                player1.PlayerCharacter.SayLine.Talk();
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();  
                Console.ForegroundColor = ConsoleColor.Red;  
                System.Console.WriteLine($"\n{player1.PlayerName} dealt {damageDealt} damage to {player2.PlayerName}");
                Console.ForegroundColor = ConsoleColor.White;
                player2.PlayerCharacter.Health = player2.PlayerCharacter.Health - damageDealt;
                System.Console.WriteLine("\nCharacter Damaged:\n");
                player2.PlayerCharacter.DisplayStats();  
            }
            else if(attackingPlayer == 2){
                
                System.Console.WriteLine("\nPlayer 2: Press any key to attack");
                Console.ReadKey();
                Console.Clear();
                player2.PlayerCharacter.AttackBehavior.Attack();
                System.Console.WriteLine("\nPlayer 1: Press any key to defend");
                Console.ReadKey();
                Console.Clear();
                player1.PlayerCharacter.DefendBehavior.Defend();
                damageDealt = (player2.PlayerCharacter.AttackStrength - player1.PlayerCharacter.DefensivePower) * (player2.Bonus); 
                if(damageDealt <= 0){
                    damageDealt = 1;
                }
                else{
                    damageDealt = damageDealt;
                }
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                player2.PlayerCharacter.SayLine.Talk();
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"\n{player2.PlayerName} dealt {damageDealt} damage to {player1.PlayerName}");
                Console.ForegroundColor = ConsoleColor.White;
                player1.PlayerCharacter.Health = player1.PlayerCharacter.Health - damageDealt;
                System.Console.WriteLine("\nCharacter Damaged:\n");
                player1.PlayerCharacter.DisplayStats();       
            }
            System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
        }

    
