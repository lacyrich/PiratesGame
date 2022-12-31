using pa2.Interfaces;
using pa2.Behaviors;
namespace pa2.Models
{
    public class JackSparrow : Character
    {
        public JackSparrow(){
            CharacterName = "Jack Sparrow";
            AttackBehavior = new Distract();
            SayLine = new JackSparrowLine();
            AttackName = "Distract";
        }

    }
}