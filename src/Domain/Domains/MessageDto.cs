namespace Domain.Domains;

public class MessageDto
{
    public string? Title { get; set; }
    public string Message { get; set; } = default!;
}