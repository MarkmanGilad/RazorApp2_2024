using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.RazorPages
{
    public class Razor3Model : PageModel
    {
        public void OnGet()
        {
            
            ViewData["Msg"] = "This is a message";
            ViewData["Number"] = 5;
            ViewData["array"] = new int [] {1,2,3};
        }

    }
}
