using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp2.Pages.Binding
{
    public class LoginModel : PageModel
    {
        public string msg { get; set; } = "";
        
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Request.Form["Username"] == "Gilad" && Request.Form["password"] == "1968" ||
                Request.Form["Username"] == "Yoav" && Request.Form["password"] == "1234")
            {
                msg = $"Welcome {Request.Form["Username"]}";
                
            } else
            {
                msg = "Wrong username or password.";
            }
        }
    }
}
