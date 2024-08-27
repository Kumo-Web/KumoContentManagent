using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class ContentDbContext : DbContext
{
    public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options)
    {

    }

    public DbSet<Page> Pages { get; set; }
    public DbSet<Element> Elements { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<Form> Forms { get; set; }
    public DbSet<FormSubmission> FormSubmissions { get; set; }
}
