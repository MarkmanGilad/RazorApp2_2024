using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Users
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // Remove a specific session key
            //HttpContext.Session.Remove("Logout");

            // Clear the entire session
            HttpContext.Session.Clear();

            return RedirectToPage("/Index");
        }
    }
}
