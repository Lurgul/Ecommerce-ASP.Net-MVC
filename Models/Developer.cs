using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }
        [Display(Name = "Pictures of the Developer")]
        public String DeveloperPicture { get; set; }
        [Display(Name = "Name of the Developer")]
        public String DeveloperName { get; set; }
        [Display(Name = "Description of the Platforms")]
        public String Description { get; set; }

        public List <Game> Games { get; set; }
    }
}
