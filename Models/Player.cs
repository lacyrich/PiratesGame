namespace pa2.Models
{
    public class Player 
    {
        public int PlayerNum {get; set;}
        public string PlayerName {get; set;}
        public double Bonus {get; set;}
        public Character PlayerCharacter {get; set;}
        public DavyJones myDavyJones {get; set;}
        public JackSparrow myJackSparrow {get; set;}
        public WillTurner myWillTurner {get; set;}
        Menu characterMenu = new Menu();

        
        public Player(){
            PlayerNum = 1;
            PlayerName = "";
            Bonus = 1;
            PlayerCharacter = new Character();
            myDavyJones = new DavyJones();
            myJackSparrow = new JackSparrow();
            myWillTurner = new WillTurner();
        }

        public void ChooseCharacter(){
            characterMenu.DisplayCharactersMenu();
            string userInput = Console.ReadLine();
            RouteEm(userInput);
            SelectCharacter();
        }

        private void RouteEm(string userInput){
            while(userInput != "1" && userInput != "2" && userInput != "3"){
                System.Console.WriteLine("Bad entry");
                characterMenu.DisplayCharactersMenu();
                userInput = Console.ReadLine();
            }
            if(userInput == "1"){
                Console.Clear();
                myDavyJones.DisplayStats();
                PlayerCharacter = myDavyJones;
            }
            else if(userInput == "2"){
                Console.Clear();
                myJackSparrow.DisplayStats();
                PlayerCharacter = myJackSparrow;
            }
            else if(userInput == "3"){
                Console.Clear();
                myWillTurner.DisplayStats();
                PlayerCharacter = myWillTurner;
            }
        }
        public void SelectCharacter(){
            System.Console.WriteLine("Would you like to play as this character? Please enter yes or no");
            string userInput = Console.ReadLine();
            if(userInput.ToLower() == "yes"){
                if(PlayerCharacter == myDavyJones){
                    System.Console.WriteLine($"You have selected {myDavyJones.CharacterName}");
                }
                else if(PlayerCharacter == myJackSparrow){
                    System.Console.WriteLine($"You have selected {myJackSparrow.CharacterName}");
                }
                else{
                    System.Console.WriteLine($"You have selected {myWillTurner.CharacterName}");
                }
            }
            else if(userInput.ToLower() == "no"){
                ChooseCharacter();
            }
            else{
                System.Console.WriteLine("Invalid Inupt. Please try again");
                ChooseCharacter();
            }
        }
    }
}