namespace MovieReminder.Domain;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<UserSession>? UserSessions { get; set; }
    public List<Movie>? Movies { get; set;  }
}
