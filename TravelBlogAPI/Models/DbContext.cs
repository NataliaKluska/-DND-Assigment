using Microsoft.EntityFrameworkCore;
using TravelBlogAPI.Models;

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
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
