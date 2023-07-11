using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [Display(Name = "Pictures of the Publisher")]
        public String Logo { get; set; }
        [Display(Name = "Name of the Publisher")]
        public String PublisherName { get; set; }
        [Display(Name = "Description of the Publisher")]

        public String Description { get; set; }
        
        public List<Game> Games { get; set; }
    }
}
