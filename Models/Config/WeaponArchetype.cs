using Models.Common;

namespace Models.Config
{
    public class WeaponArchetype
    {
        public GunType GunType {get; set;}
        public string Bonus { get; set;}
        public WeaponArchetypeSpecs[] WeaponSpecs { get; set;}
        public string[] Names {get; set;}
    }

}