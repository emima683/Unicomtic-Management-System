using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTicManagementSystem.Controllers
{
    internal class LoginController
    {
        public LoginController() { }

        public LoginController(User user)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO USER (username, password, role) VALUE ('Admin', 'admin' 'Admin@123')," +
                                "INSERT INTO USER (username, password, role) VALUE ('Lecture', 'lecture', 'Lecture@123')," +
                                "INSERT INTO USER (username, password, role) VALUE ('Staff', 'staff', 'Staff@123')," +
                                "INSERT INTO USER (username, password, role) VALUE ('Student', 'student', 'Student@123');";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        
        
        
    }
}
