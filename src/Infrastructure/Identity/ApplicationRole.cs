using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity;

public class ApplicationRole : IdentityRole<Guid>
{
    // Additional properties for your application
        public string Description { get; set; }   // Description of the role
        public DateTime CreatedAt { get; set; }   // Date when the role was created
        public DateTime? UpdatedAt { get; set; }  
}
