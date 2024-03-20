using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;



namespace WebApplication1.Models
{
    public class Table_1 : Controller
    {
        public static string con_string = "Server=tcp:cldv-server-sql.database.windows.net,1433;Initial Catalog=cldv-DB;Persist Security Info=False;User ID=stephane-kib;Password=CTMMonecole1@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            public static SqlConnection con = new SqlConnection(con_string);

        public String Name { get; set; }
        public String SurName { get; set; }
        public String Email { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public int insert_User(Table_1 m)
        {
            string sql = "INSERT INTO Table_1 (userName, userSurname, userEmail) VALUES(@Name, @SurName,@Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", m.Name);
            cmd.Parameters.AddWithValue("@SurnName", m.SurName);
            cmd.Parameters.AddWithValue("@Email", m.Email);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();   
            con.Close();
            return rowsAffected;
        }
    }
}
