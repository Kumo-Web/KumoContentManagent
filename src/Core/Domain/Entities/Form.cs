namespace Domain.Entities;

public class Form
{
    public Guid FormId { get; set; }
    public string Title { get; set; }
    public string Fields { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; } 

    public Form()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
