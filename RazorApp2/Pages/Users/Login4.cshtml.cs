using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Users
{
    public class Login4Model : PageModel
    {
        public string msg { get; set; } = string.Empty;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
            //Username = "After Get";
        }
        public IActionResult OnPost()
        {
            if (Username == "Gilad" && Password == "1968" ||
                Username == "Orly" && Password == "1234")
            {
                HttpContext.Session.SetString("Login", Username);
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToPage("/Index");
            }
            else if (Username == "Etay" && Password == "11111")
            {
                HttpContext.Session.SetString("Login", Username);
                HttpContext.Session.SetString("Admin", "False");
                return RedirectToPage("/Index");
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
