using System.ComponentModel.DataAnnotations;

namespace service_deskjr.Models
{
    public class RegisterModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; } 

    [Required]
    public string FullName { get; set; } 
}

}
