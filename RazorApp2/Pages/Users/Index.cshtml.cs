using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp2.Model;
using System.Data;


namespace RazorApp2.Pages.Users
{
    public class IndexModel : PageModel
    {
        public DataTable dt {  get; set; }

        public void OnGet()
        {
            Helper helper = new Helper();
            string SQL = "SELECT * FROM Users";
            dt = helper.RetrieveTable(SQL, "Users");
        }
    }
}
