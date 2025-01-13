namespace service_deskjr.Models;
using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
}
