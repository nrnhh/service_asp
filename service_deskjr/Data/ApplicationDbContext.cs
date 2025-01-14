using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using service_deskjr.Models; 

namespace service_deskjr.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<LoginModel> loginModels    { get; set; }
     public DbSet<RegisterModel> registerModels    { get; set; }

       public DbSet<User> users    { get; set; }

}
