using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using service_deskjr.Models; // Modelleri içeren namespace'i ekleyin

namespace service_deskjr.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Modellerinizi buraya ekleyin
    public DbSet<Ticket> Tickets { get; set; }
}
