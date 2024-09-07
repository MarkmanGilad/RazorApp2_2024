using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Binding
{
    public class Login3Model : PageModel
    {
        public string msg { get; set; } = string.Empty;

        [BindProperty]
        public string Username { get; set; } = "";

        [BindProperty]
        public string password { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username == "Gilad" && password == "1968")
            {
                return RedirectToPage("/Index");
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
