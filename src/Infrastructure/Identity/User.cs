using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity;

public class User : IdentityUser
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public User()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
