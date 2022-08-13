namespace MovieReminder.Domain;

public class MovieSource
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Link { get; set; }
    public int MovieId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Movie? Movie { get; set; }
}
