using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class ContentDbContext : DbContext
{
    public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options)
    {

    }

    public DbSet<Page> Pages { get; set; }
    public int MyProperty { get; set; }
}
