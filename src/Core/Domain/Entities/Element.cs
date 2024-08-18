namespace Domain.Entities;

public class Element
{
    public Guid ElementId { get; set; }
    public string Type { get; set; }
    //properties in json format eg color:blue etc
    public string Properties { get; set; } 
    public int? PageId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Page Page { get; set; }
    public Element()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
