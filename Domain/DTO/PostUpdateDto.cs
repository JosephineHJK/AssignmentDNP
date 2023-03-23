namespace Entities.DTO;

public class PostUpdateDto
{
    public int Id { get; }
    public int? OwnerId { get; set; }
    public string? Title { get; set; }
    
    public string Text { get; set; }
    
    public bool? IsCompleted { get; set; }

    public PostUpdateDto(int id)
    {
        Id = id;
    }
    
}