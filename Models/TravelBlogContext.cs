using Microsoft.EntityFrameworkCore;

namespace TravelBlogApi.Models;

public class TravelBlogContext : DbContext
{
    public TravelBlogContext(DbContextOptions<TravelBlogContext> options)
        : base(options)
    {
    }

    public DbSet<TravelBlogItem> TravelBlogItems { get; set; } = null!;
}