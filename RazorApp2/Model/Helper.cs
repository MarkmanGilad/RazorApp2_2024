using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RazorApp2.Model
{
    public class Helper
    {
        private string conString;

        public Helper()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            conString = configuration.GetConnectionString("UsersDB");

        }

        public DataTable RetrieveTable(string SQLStr, string table)
        // Gets A table from the data base acording to the SELECT Command in SQLStr;
        // Returns DataSet with the Table.
        {
            // connect to DataBase
            SqlConnection con = new SqlConnection(conString);

            // Build SQL Query
            SqlCommand cmd = new SqlCommand(SQLStr, con);

            // Build DataAdapter
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            // Build DataSet to store the data
            DataSet ds = new DataSet();

            // Get Data form DataBase into the DataSet
            ad.Fill(ds, table);

            return ds.Tables[table];
        }

        public int Insert(User user, string table)
        // The Method recieve a user objects and insert it to the Database as new row. 
        // if the user is already taken the method will return -1.
        {
            // התחברות למסד הנתונים
            SqlConnection con = new SqlConnection(conString);

            // בניית פקודת SQL
            string SQLStr = $"SELECT * FROM {table} WHERE Username Like '{user.Username}'";
            SqlCommand cmd = new SqlCommand(SQLStr, con);

            // בניית DataSet
            DataSet ds = new DataSet();

            // טעינת סכימת הנתונים
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, table);

            if (ds.Tables[table].Rows.Count > 0)
            {
                return -1;
            }

            // בניית השורה להוספה
            DataRow dr = ds.Tables[table].NewRow();
            dr["Firstname"] = user.FirstName;
            dr["Lastname"] = user.LastName;
            dr["Username"] = user.Username;
            dr["Password"] = user.Password;
            dr["Email"] = user.Email;
            dr["Phone"] = user.Phone;
            dr["Birthday"] = user.Birthday.ToString();

            ds.Tables[table].Rows.Add(dr);

            // עדכון הדאטה סט בבסיס הנתונים
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            int n = adapter.Update(ds, table);
            return n;
        }

        public int ExecuteNonQuery(string SQL)
        {
            // התחברות למסד הנתונים
            SqlConnection con = new SqlConnection(conString);

            // בניית פקודת SQL
            SqlCommand cmd = new SqlCommand(SQL, con);

            // ביצוע השאילתא
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();

            // return the number of rows affected
            return n;
        }

        public int Delete(int id, string table)
        {
            if (id == 0)
            {
                return -1;
            }
            string SQL = $"DELETE FROM {table} WHERE ID = {id}";
            int n= ExecuteNonQuery(SQL);
            return n;
        }

        public string Update(User user, string table)
        {
            Helper helper = new Helper();

            string SQL = $"UPDATE {table} " +
                $"SET Username='{user.Username}', Password = '{user.Password}', " +
                $"FirstName  = '{user.FirstName}', LastName = '{user.LastName}', " +
                $"Email = '{user.Email}', Phone = '{user.Phone}',  Admin = '{user.Admin}', " +
                $"Birthday = '{user.Birthday:MM-dd-yyyy HH:mm:ss}' " +
                $"WHERE Id = {user.ID}";
            int n;
            string msg = "";
            try
            {
                n = ExecuteNonQuery(SQL);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
    
    }
}
