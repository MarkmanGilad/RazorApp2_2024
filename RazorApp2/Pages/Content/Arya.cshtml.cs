using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Content
{
    public class AryaModel : PageModel
    {
        public IActionResult OnGet()
        {
            //return Redirect("/AccessDenied");
            return Page();
        }

        public void OnPost() 
        { 

        }

    }
}
