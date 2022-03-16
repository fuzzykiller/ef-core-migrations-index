using efcoretest.Model;
using Microsoft.EntityFrameworkCore;

namespace efcoretest;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Hour> Hours => Set<Hour>();
    public DbSet<Minute> Minutes => Set<Minute>();
}