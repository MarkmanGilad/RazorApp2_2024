using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Users
{
    public class Login3Model : PageModel
    {
        public string msg { get; set; } = string.Empty;

        [BindProperty]
        public string Username { get; set; }
        
        [BindProperty]
        public string password { get; set; }

        public void OnGet()
        {
            Username = "After Get";
        }
        public IActionResult OnPost()
        {
            if (Username == "Gilad" && password == "1968")
            {
                HttpContext.Session.SetString("Login", Username);
                HttpContext.Session.SetString("Admin", "True");
                //Username = "After Post";
                //return Page();
                return RedirectToPage("/Index");
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
