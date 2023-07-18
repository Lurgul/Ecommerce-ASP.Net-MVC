using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Platforms
    {
        [Key]
        public int PlatformId { get; set; }

        [Display(Name = "Pictures of the Platform")]
        [Required(ErrorMessage ="Platforms's picture is required!")]
        public String PlatformPicture { get; set; }

        public String PlatformName { get; set; }
        [Display(Name = "Name of the Platform")]
        [Required(ErrorMessage = "Platforms's name is required!")]


        public String Description { get; set; }
        

        public List<Platforms_Games>? Platforms_Games { get; set; }
    }
}
