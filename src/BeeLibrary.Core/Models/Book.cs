namespace BeeLibrary.Core.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Subtitle { get; set; }
    public string Author { get; set; } = string.Empty;
    public string? Description { get; set; }

    // Bibliographic fields
    public string? Isbn { get; set; }
    public string? Publisher { get; set; }
    public int? PublishedYear { get; set; }
    public string Language { get; set; } = "uk";
    public int? PageCount { get; set; }

    // File information
    public string? FilePath { get; set; }
    public string? OriginalFileName { get; set; }
    public BookFormat? Format { get; set; }
    public long? FileSizeBytes { get; set; }
    public string? CoverImagePath { get; set; }

    // Credibility
    public CredibilityStatus Credibility { get; set; } = CredibilityStatus.Unverified;
    public string? CredibilityNotes { get; set; }

    // Metadata
    public string? Slug { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}
