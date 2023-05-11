using Microsoft.EntityFrameworkCore;
using SimApi.Data.Domain;

namespace SimApi.Data.Context;

public class SimDbContext : DbContext
{
    public SimDbContext(DbContextOptions<SimDbContext> options) : base(options)
    {

    }
    
   
    public DbSet<staff> staff { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<staff>().HasIndex(x => x.Email).IsUnique(true);

    }
}
