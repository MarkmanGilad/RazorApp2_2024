using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorApp2.Pages.Users
{
    public class LoginModel : PageModel
    {
        public string msg { get; set; } = string.Empty;
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            string userName = Request.Form["Username"];
            string password = Request.Form["password"];
            
            if (userName == "Gilad" && password == "1968")
            {
                HttpContext.Session.SetString("Login", userName);
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToPage("/Index");
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
