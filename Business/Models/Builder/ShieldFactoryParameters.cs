using System.ComponentModel.DataAnnotations;

namespace Business.Models.Builder
{
    public class ShieldFactoryParameters : BaseFactoryParameters
    {
        [Required]
        [Range(1, 30)]
        public int PlayerLevel {get; set;}

        public string Guild {get; set;}
    }
}