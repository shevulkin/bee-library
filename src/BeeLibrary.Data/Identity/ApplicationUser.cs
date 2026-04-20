using BeeLibrary.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace BeeLibrary.Data.Identity;

/// <summary>
/// Identity-специфічна реалізація користувача для EntityFramework
/// </summary>
public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Конвертація в доменну модель
    /// </summary>
    public User ToUser()
    {
        return new User
        {
            Id = Id,
            Email = Email ?? string.Empty,
            FirstName = FirstName,
            LastName = LastName,
            CreatedAt = CreatedAt,
            IsActive = IsActive
        };
    }

    /// <summary>
    /// Створення з доменної моделі
    /// </summary>
    public static ApplicationUser FromUser(User user)
    {
        return new ApplicationUser
        {
            Id = user.Id,
            Email = user.Email,
            UserName = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            CreatedAt = user.CreatedAt,
            IsActive = user.IsActive
        };
    }
}
