using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Stateless
{
    public class Stateless4Model : PageModel
    {
        public void OnGet()
        {
            if (HttpContext.Session.Get("counter") == null)
            {
                HttpContext.Session.SetInt32("counter", 0);
            }
        }
        public void OnPost()
        {
            int? counter = HttpContext.Session.GetInt32("counter");
            HttpContext.Session.SetInt32("counter", (int)counter + 1);

        }
    }
}
