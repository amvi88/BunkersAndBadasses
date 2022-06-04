using Business.Models.Common;

namespace Business.Models
{
    public class Grenade : Item    
    {
        public int Level {get; set;}

        public string Damage {get; set;}

        public int AmountOfDice => int.Parse(Damage.Substring(0,1));

        public string DiceType => Damage.Substring(1);

        public string GrenadeType {get; set;}  

        public string Effect {get; set;}

        public Element Element {get; set;}
    }
}
