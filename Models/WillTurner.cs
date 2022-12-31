using pa2.Interfaces;
using pa2.Behaviors;
namespace pa2.Models
{
    public class WillTurner : Character
    {
        public WillTurner(){
            CharacterName = "Will Turner";
            AttackBehavior = new Sword();
            SayLine = new WillTurnerLine();
            AttackName = "Sword";
        }

    }
}