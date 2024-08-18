namespace Domain.Entities;

public class Page
{
   
    public int PageId { get; set; }
    public required string Title {get; set;}
    public string? Slug { get; set; }
    public required string Content { get; set; }
    public int? ParentPageId { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; set; }
    public Page ParentPage { get; set; }
    public ICollection<Page> ChildPages { get; set; }
    public Page()
    {
        CreatedAt = DateTime.UtcNow;
    }

}
