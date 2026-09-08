using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20,MinimumLength =5, ErrorMessage ="il faut que le nom contient entre 5 et 20 caractères")]
        public string Name { get; set; }

        [MaxLength(20, ErrorMessage = "Entre 1 et 20 stp man")]
        public int Point { get; set; }

        [MaxLength(255, ErrorMessage = "criss que cest long, essaie max 255")]
        public string ShortDesc { get; set; }

        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        
        public int ZombieTypeId { get; set; }
        
        public ZombieType ZombieType { get; set; }



      
    }
}
