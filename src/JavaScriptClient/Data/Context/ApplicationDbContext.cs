using JavaScriptClient.Data.Clients;
using Microsoft.EntityFrameworkCore;

namespace JavaScriptClient.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
}