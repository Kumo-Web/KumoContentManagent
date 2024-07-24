namespace Domain.Entities;

public class Page
{
    private string _title;
    private string _content;
    public int PageId { get; set; }
    public string Title
    {
        get => _title;
        set => _title = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Title cannot be empty", nameof(Title));
    }
    public string? Slug { get; set; }
    public string Content
    {
        get => _content;
        set => _content = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Content cannot be empty", nameof(Content));
    }
    public int? ParentPageId { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; set; }

    public Page()
    {
        CreatedAt = DateTime.UtcNow;
    }

}
