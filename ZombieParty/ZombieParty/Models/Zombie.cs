using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        
        public int ZombieTypeId { get; set; }
        
        public ZombieType ZombieType { get; set; }
        public int Point { get; set; }
    }
}
