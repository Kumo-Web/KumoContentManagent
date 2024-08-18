using Domain.Entities;
using Infrastructure.Identity;

namespace Infrastructure.ExtensionMappers;

public class UserMapper
{
    public static User MapToDomainUser(ApplicationUser appUser)
    {
        return new User
        {
            Id = appUser.Id,
            UserName = appUser.UserName,
            Email = appUser.Email,
            FullName = appUser.FullName,
            CreatedAt = appUser.CreatedAt,
            UpdatedAt = appUser.UpdatedAt
        };
    }

    public static ApplicationUser MapToApplicationUser(User user)
    {
        return new ApplicationUser
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            FullName = user.FullName,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
}
