using Domain.Entities;
using Infrastructure.Identity;

namespace Infrastructure.ExtensionMappers;

public class RoleMapper
{
    public static Role MapToDomainRole(ApplicationRole appRole)
    {
        return new Role 
        {
            Id = appRole.Id,
            Name = appRole.Name,
            Description = appRole.Description,
            CreatedAt =appRole.CreatedAt,
            UpdatedAt = appRole.UpdatedAt
        };
    }
    public static ApplicationRole MapToApplicationRole(Role role)
    {
        return new ApplicationRole
        {
            Id = role.Id,
            Name = role.Name,
            Description = role.Description,
            CreatedAt = role.CreatedAt,
            UpdatedAt = role.UpdatedAt
        };
    }
}
