using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public string FullName { get; set; }          // Full name of the user
    public string ProfilePictureUrl { get; set; }   // Example of a domain-specific property
    public DateTime CreatedAt { get; set; }  // Example of a domain-specific property
    public DateTime? UpdatedAt { get; set; }

    public ApplicationUser()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
