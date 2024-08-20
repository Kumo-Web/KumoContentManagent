namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }     // Maps to ApplicationUser.UserName
    public string Email { get; set; }        // Maps to ApplicationUser.Email
    public string FullName { get; set; }     // Example of a domain-specific property
    public DateTime CreatedAt { get; set; }  // Example of a domain-specific property
    public DateTime? UpdatedAt { get; set; }
    public string Role { get; set; }
}
