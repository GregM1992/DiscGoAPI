namespace DiscGoAPI.Models
{
    public class BaggedDisc
    {
        public int Id { get; set; }
        public string DiscId { get; set; }
        public int Aces { get; set; }
        public int BagId { get; set; }
        public int Birdies { get; set; }
        public string? Brand { get; set; }
        public string? Category { get; set; }
        public string? Color { get; set; }
        public int Fade { get; set; }
        public int Glide { get; set; }
        public string? Name { get; set; }
        public int Speed { get; set; }
        public string? Stability { get; set; }
        public int Turn { get; set; }
        public bool? Favorite { get; set; }
    }
}
