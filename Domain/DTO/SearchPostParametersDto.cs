namespace Entities.DTO;

public class SearchPostParametersDto
{
    public string? Username { get;}
    public string? Password { get; }
    
    public int? UserId { get;}
    public bool? CompletedStatus { get;}
    public string? TitleContains { get;}
    
    public string? TextContains { get; }

    public SearchPostParametersDto(string? username, int? userId, bool? completedStatus, string? titleContains, string? textContains, string? password)
    {
        Username = username;
        UserId = userId;
        CompletedStatus = completedStatus;
        TitleContains = titleContains;
        TextContains = textContains;
        Password = password;
    }
}