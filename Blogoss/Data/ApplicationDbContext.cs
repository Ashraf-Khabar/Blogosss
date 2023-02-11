using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blogoss.Models;

namespace Blogoss.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Blogoss.Models.Blog> Blog { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
    }
}