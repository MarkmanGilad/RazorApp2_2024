using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.RazorPages
{
    public class Razor1Model : PageModel
    {
        public string Str { get; set; } = string.Empty;

        public void OnGet()
        {
            Str = "Gilad Markman";
        }
    }
}
