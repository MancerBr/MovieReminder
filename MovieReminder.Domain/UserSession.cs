namespace MovieReminder.Domain;

public class UserSession
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? Token { get; set; }
    public DateTime Exp { get; set; }
    public User? User { get; set; }

}
