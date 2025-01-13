namespace service_deskjr.Models;


public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } // Open, In Progress, Resolved
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public string UserId { get; set; }
    public User User { get; set; }
}
