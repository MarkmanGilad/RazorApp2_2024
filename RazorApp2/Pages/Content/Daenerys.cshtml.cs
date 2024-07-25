using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Content
{
    public class DaenerysModel : PageModel
    {
        public IActionResult OnGet()
        {
            string login = HttpContext.Session.GetString("Login");
            if (string.IsNullOrEmpty(login))
            {
                return RedirectToPage("/AccessDenied");
            }
            return Page();
        }
    }
}
