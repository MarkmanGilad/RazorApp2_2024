using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Users
{
    public class Login2Model : PageModel
    {
        public string msg { get; set; } = string.Empty;
        public void OnGet()
        {
        }
        
        public IActionResult OnPost(string Username, string password)
        {           

            if (Username == "Gilad" && password == "1968")
            {
                HttpContext.Session.SetString("Login", Username);
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToPage("/Index");
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
