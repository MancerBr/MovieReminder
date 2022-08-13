namespace MovieReminder.Domain;

public class Genre
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<MovieGenre>? MovieGenres { get; set; }
}
