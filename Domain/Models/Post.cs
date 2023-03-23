namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public User Owner { get; }
    public string Title { get; }
    
    public string NewText { get; }

    public int Karma { get; }
    
    public bool IsCompleted { get; set; }

    public Post(User owner, string title, string newText, int karma)
    {
        Owner = owner;
        Title = title;
        NewText = newText;
        Karma = karma;
    }
}