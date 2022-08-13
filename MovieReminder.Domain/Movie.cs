namespace MovieReminder.Domain;

public class Movie
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public User? User { get; set; }
    public List<MovieSource>? movieSources { get; set; }
    public List<MovieGenre>? MovieGenres { get; set; }
    public List<MovieCategory>? MovieCategories { get; set; }
}
