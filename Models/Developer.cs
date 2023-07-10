using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }
        public String DeveloperPicture { get; set; }
        public String DeveloperName { get; set; }
        public String Description { get; set; }

        public List <Game> Games { get; set; }
    }
}
