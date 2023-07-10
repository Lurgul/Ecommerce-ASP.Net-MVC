using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public String Logo { get; set; }
        public String PublisherName { get; set; }
        public String Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
