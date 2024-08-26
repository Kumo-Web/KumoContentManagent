namespace Domain.Entities;

public class MenuItem
{
     public Guid MenuItemId { get; set; }
     public int MenuId { get; set; }
     public string  Title { get; set; }
     public Uri Url { get; set; }
     public Guid? ParentMenuItemId { get; set; }
     public DateTime CreatedAt { get; set; }
     public DateTime? UpdatedAt { get; set; }

     public MenuItem()
     {
        CreatedAt = DateTime.UtcNow;
     }
}
