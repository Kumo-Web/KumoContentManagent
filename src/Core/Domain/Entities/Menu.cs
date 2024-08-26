namespace Domain.Entities;

public class Menu
{
    public int MenuId { get; set; }
    public string Title { get; set; }
    public DateTime CreadedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Menu()
    {
        CreadedAt = DateTime.UtcNow;
    }
}
