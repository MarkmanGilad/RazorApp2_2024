using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp2.Model;
using System.Data;

namespace RazorApp2.Pages.Users
{
    public class Index1Model : PageModel
    {
        public DataTable dt { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
            {
                //return RedirectToPage("/AccessDenied");
            }
            
            Helper helper = new Helper();
            string SQL = "SELECT * FROM Users";
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
        }
    }
}
