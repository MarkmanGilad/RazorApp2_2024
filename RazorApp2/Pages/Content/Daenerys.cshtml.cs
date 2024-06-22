using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Content
{
    public class DaenerysModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Login")))
            {
                return RedirectToPage("/AccessDenied");
            }
            return Page();
        }
    }
}
