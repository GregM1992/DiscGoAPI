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
        public string? Fade { get; set; }
        public string? Glide { get; set; }
        public string? Name { get; set; }
        public string? Speed { get; set; }
        public string? Stability { get; set; }
        public string? Turn { get; set; }
        public string? Background_color { get; set; }
        public bool? Favorite { get; set; }
        public string? Pic { get; set; }
    }
}
