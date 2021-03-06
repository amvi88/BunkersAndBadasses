using Models.Common;
using Models.Config;

namespace Models.Builder
{
    public class Gun : Item
    {
        public Rarity Rarity{get; set; }

        public Element Element {get; set; }

        public int Level {get; set; }

        public string Damage {get; set; }
        
        public int AmountOfDice => int.Parse(Damage.Substring(0,1));

        public string DiceType => Damage.Substring(1);

        public int ExtraAmountOfDice => string.IsNullOrWhiteSpace(ExtraDamage) ? 0 : int.Parse(ExtraDamage.Substring(0,1));

        public string ExtraDiceType =>  string.IsNullOrWhiteSpace(ExtraDamage)? string.Empty : ExtraDamage.Substring(1);

        public int Range { get; set; }

        public string Name { get; set; }

        public string GunType { get; set; }

        public RedText RedText {get; set;}

        public List<string> Bonuses {get; set;}

        public List<WeaponHits> HitsByAccuracy { get; set; }
        public string ExtraDamage { get; set; }

        public string Source { get; set; }

        public string ImageUrl { get; set; }
    }
}