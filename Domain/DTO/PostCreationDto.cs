namespace Entities.DTO;

public class PostCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }
    public string NewText { get; }
    public int Karma { get; }
    public Vote Votetype{ get; }

    public PostCreationDto(int ownerId, string title, string newText,Vote votetype)
    {
        OwnerId = ownerId;
        Title = title;
        NewText = newText;
        Karma = 0;
        Votetype = votetype;
    }
}

public enum Vote
{
    Upvote=1,
    DownVote=-1
}