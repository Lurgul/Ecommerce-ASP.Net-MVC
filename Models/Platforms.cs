using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Platforms
    {
        [Key]
        public int PlatformId { get; set; }
        public String PlatformPicture { get; set; }
        public String PlatformName { get; set; }
        public String Description { get; set; }

        public List<Platforms_Games> Platforms_Games { get; set; }
    }
}
