using Microsoft.EntityFrameworkCore;


namespace RazorPagesProject.Data
{
    public class RazorPagesProjectContext : DbContext
    {
        public RazorPagesProjectContext (DbContextOptions<RazorPagesProjectContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<RazorPagesProject.Models.Product> product { get; set; } = default!;
    }
}
