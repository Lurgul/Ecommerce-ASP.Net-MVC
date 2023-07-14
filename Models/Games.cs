using GameStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models
{
    public class Games
    {
        [Key]
        public int GameId { get; set; }
        public String NameOfTheGame { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GameCategory GameCategory { get; set; }

        public List<Platforms_Games> Platforms_Games { get; set; }

        // Publisher 
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
        
        // Developers
        public int DeveloperId { get; set; }
        [ForeignKey("DeveloperId")]
        public Developer Developer { get; set; }
    }
}
