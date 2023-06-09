namespace Domain.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    
    public int Karma { get; }
    
    public List<Post> Posts { get; set; }
}