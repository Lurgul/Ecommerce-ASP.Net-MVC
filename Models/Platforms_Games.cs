namespace GameStore.Models
{
    public class Platforms_Games
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int PlatformId { get; set; }
        public Platforms Platforms { get; set; }
    }
}
