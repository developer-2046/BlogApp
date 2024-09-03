namespace BlogApp.Models;

public class User
{
    public int Id { get; set; }
    public String Username { get; set; }
    public String Email { get; set; }
    public String PasswordHash { get; set; }
}