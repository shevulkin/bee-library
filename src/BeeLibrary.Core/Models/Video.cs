namespace BeeLibrary.Core.Models;

public class Video
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}
