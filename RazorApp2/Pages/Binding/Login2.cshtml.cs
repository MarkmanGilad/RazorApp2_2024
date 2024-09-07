using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Binding
{
    public class Login2Model : PageModel
    {
        public string msg { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPost(string Username, string password)
        {
            if (Username == "Gilad" && password == "1968")
            {
                msg = $"Welcome {Username}";
                return Page();
            }
            msg = "Wrong username or password.";
            return Page();
        }
    }
}
