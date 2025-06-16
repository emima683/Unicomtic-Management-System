using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Data
{
    internal class Migration
    {
        public void Create_Table()
        {
            using (var conn = DBConfig.GetConnection())

            {
                string query = @"
                               CREATE TABLE IF NOT EXISTS Student (ID INTEGER PRIMARY KEY AUTOINCREMENT, First_Name TEXT, Last_Name TEXT, Address TEXT, Stream TEXT);
                               CREATE TABLE IF NOT EXISTS User (ID INTEGER PRIMARY KEY AUTOINCREMENT, Role TEXT, UserName TEXT, Password STRING);
                               CREATE TABLE IF NOT EXISTS Session (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL);
                               CREATE TABLE IF NOT EXISTS Tmitable (ID INTEGER PRIMARY KEY AUTOINCREMENT, TimeSlot TEXT NOT NULL,SubjectName TEXT NOT  NULL);




                               ";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.ExecuteNonQuery();
                }


            }

}
    }
}
