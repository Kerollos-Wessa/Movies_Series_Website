namespace Movies.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Age { get; set; }
        public string? Image { get; set; }
        public bool IsDeleted { get; set; } = false;
        public String? Overview { get; set; }
    }
}
