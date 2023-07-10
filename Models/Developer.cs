using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Developer
    {
        [Key]
        public int PlatformId { get; set; }
        public String PlatformPicture { get; set; }
        public String PlatformName { get; set; }
        public String Description { get; set; }

        public List <Game> Games { get; set; }
    }
}
