using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Stateless
{
    public class Stateless3Model : PageModel
    {
        
        public void OnGet()
        {
            ViewData["counter"] = 0;
        }
        public void OnPost()
        {
            ViewData["counter"] = (int)ViewData["counter"] + 1;
        }
    }
}
