using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Password { get; set; }
    public string ConfirmPassword { get; internal set; }

    public IActionResult OnPost()
    {
        // Kayıt işlemi
        // Bu kısımda kullanıcı veritabanına eklenir
        return RedirectToPage("/Login");
    }
}
