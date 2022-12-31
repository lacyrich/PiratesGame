using pa2.Interfaces;
using pa2.Behaviors;
namespace pa2.Models
{
    public class DavyJones : Character
    {
        public DavyJones(){
            CharacterName = "Davy Jones";
            AttackBehavior = new CannonFire();
            SayLine = new DavyJonesLine();
            AttackName = "Cannon Fire";
        }

    }

}