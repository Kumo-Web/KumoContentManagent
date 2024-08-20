namespace Domain.Entities;

public class Template
{
    public int TemplateId { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public User CreatedByUser { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Template()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
