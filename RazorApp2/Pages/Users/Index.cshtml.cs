using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp2.Model;
using System.Data;


namespace RazorApp2.Pages.Users
{
    public class IndexModel : PageModel
    {
        public DataTable dt { get; set; }
        [BindProperty]
        public string filter { get; set; } = string.Empty;
        [BindProperty]
        public string column { get; set; }
        [BindProperty]
        public string Order { get; set; }
        [BindProperty]
        public int Id { get; set; }
        

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
            {
                return RedirectToPage("/AccessDenied");
            }
            Helper helper = new Helper();
            string SQL = "SELECT * FROM Users";
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
        }

        public IActionResult OnPostFilter()
        {
            Helper helper = new Helper();
            string SQL;
            if (filter == string.Empty)
            {
                SQL = "SELECT * FROM Users";
            }
            else
            {
                SQL = $"SELECT * FROM Users WHERE Firstname LIKE '%{filter}%' OR Lastname Like '%{filter}%'";
            }
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
        }

        public IActionResult OnPostSort()
        {
            Helper helper = new Helper();
            string SQL = $"SELECT * FROM Users ORDER BY {column} {Order}";
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
        }
        public IActionResult OnPostDelete()
        {
            Helper helper = new Helper();
            helper.Delete(Id, "Users");
            string SQL = "SELECT * FROM Users";
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
            
        }

        public IActionResult OnGetUpdate(string param)
        {
            Helper helper = new Helper();
            helper.Delete(Id, "Users");
            string SQL = "SELECT * FROM Users";
            dt = helper.RetrieveTable(SQL, "Users");
            return Page();
        }
    }
}
