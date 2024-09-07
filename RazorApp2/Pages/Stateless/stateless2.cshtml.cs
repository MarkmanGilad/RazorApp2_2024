using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Stateless
{
    public class stateless2Model : PageModel
    {
        [BindProperty]
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
