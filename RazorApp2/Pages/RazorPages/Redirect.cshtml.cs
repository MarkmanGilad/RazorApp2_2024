using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.RazorPages
{
    public class RedirectModel : PageModel
    {
        public void OnGet() { 

        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/AccessDenied");
        }
    }
}
