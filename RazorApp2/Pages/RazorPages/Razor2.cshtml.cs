using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.RazorPages
{
    public class Razor2Model : PageModel
    {
        public string Str { get; set; } = "";
        public string User { get; set; } = string.Empty;

        public void OnGet()
        {
            this.Str = "Gilad Markman from Backend";
            User = "Gilad1";
        }
        public string printText()
        {
            return "Hello World!"; 
        }
    }
}
