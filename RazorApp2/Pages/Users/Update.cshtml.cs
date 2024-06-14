using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp2.Model;
using System.Data;

namespace RazorApp2.Pages.Users
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public User NewUser { get; set; } = new User();
        public string msg { get; set; } = string.Empty;
        
        public IActionResult OnGet(string param)
        {
            int id = int.Parse(param);
            Helper helper = new Helper();
            string SQL = $"SELECT * FROM Users WHERE Id = {id}";
            DataTable dt = helper.RetrieveTable(SQL, "Users");
            DataRow dr = dt.Rows[0];
            //User user = new User();
            NewUser.ID = id;
            NewUser.Username = dr["Username"].ToString();
            NewUser.Password = dr["Password"].ToString();
            NewUser.FirstName = dr["Firstname"].ToString();
            NewUser.LastName = dr["Lastname"].ToString();
            NewUser.Email = dr["Email"].ToString();
            NewUser.Phone = dr["Phone"].ToString();
            NewUser.Admin = (bool)dr["Admin"];
            NewUser.Birthday = DateTime.Parse(dr["Birthday"].ToString());
                        
            return Page();

        }

        public IActionResult OnPost()
        {
            Helper helper = new Helper();
            msg = helper.Update(NewUser, "Users");
            if (msg =="")
                return RedirectToPage("Index");
            return Page();

        }
    }
}
