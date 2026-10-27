using Microsoft.EntityFrameworkCore;
using Arishma.Leads.Domain;
namespace Arishma.Leads.Infrastructure;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Lead> Leads => Set<Lead>();
    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Lead>().ToTable("leads");
        base.OnModelCreating(b);
    }
}
