namespace Entities.DTO;

public class PostCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }
    
    public string NewText { get; }
    public int Karma { get; }

    public PostCreationDto(int ownerId, string title, string newText, int karma)
    {
        OwnerId = ownerId;
        Title = title;
        NewText = newText;
        Karma = karma;
    }
}