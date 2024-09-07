using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Stateless
{
    public class Stateless1Model : PageModel
    {
        public int counter { get; set; }

        public void OnGet()
        {
            counter = 0;
        }
        public void OnPost()
        {
            counter++;
        }
    }
}
