namespace BeeLibrary.Core.Models;

/// <summary>
/// Доменна модель користувача (без залежності від Identity)
/// </summary>
public class User
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}
