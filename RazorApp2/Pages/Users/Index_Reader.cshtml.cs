using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RazorApp2.Model;

namespace RazorApp2.Pages.Users
{
    public class Index_ReaderModel : PageModel
    {
        public SqlDataReader Reader { get; set; }

        public void OnGet()
        {
            Helper helper = new Helper();
            string SQL = "SELECT * FROM Users";
            Reader = helper.GetDataReader(SQL);
        }
    }
}
