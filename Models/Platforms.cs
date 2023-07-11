using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Platforms
    {
        [Key]
        public int PlatformId { get; set; }

        [Display(Name = "Pictures of the Platform")]
        public String PlatformPicture { get; set; }


        [Display(Name = "Name of the Platform")]
        public String PlatformName { get; set; }


        [Display(Name = "Description of the Publisher")]
        public String Description { get; set; }
        

        public List<Platforms_Games> Platforms_Games { get; set; }
    }
}
