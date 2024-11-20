using Microsoft.EntityFrameworkCore;
using TravelBlogShared.Models; 
namespace TravelBlogAPI.Data
{
    public class TravelBlogContext : DbContext
    {
        public TravelBlogContext(DbContextOptions<TravelBlogContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TravelPost> Posts { get; set; }
    }
}
