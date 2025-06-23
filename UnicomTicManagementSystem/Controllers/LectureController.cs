using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class LectureController
    {
        public LectureController() { }

        public LectureController(Lecture lecture)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Lecture (Name, Address, Subject) VALUES (@name, @address, @subject,);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", lecture.Name);
                    cmd.Parameters.AddWithValue("@address", lecture.Address);
                    cmd.Parameters.AddWithValue("@subject", lecture.Subject);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Add sucessful!!!");
                }
            }
        }

        public List<Lecture> show_Output()
        {
            List<Lecture> lecture = new List<Lecture>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Student ;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lecture.Add(new Lecture
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                Subject = reader.GetString(3)

                               

                            });




                        }
                    }
                }
                return lecture;
            }
        }

        public List<Lecture> get_Lecture_info()
        {
            List<Lecture> Lecture = new List<Lecture>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Lecture ;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lecture.Add(new Lecture
                            {                                                    // (Name, Address, Subject) VALUES (@name, @address, @subject,);";
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                Subject = reader.GetString(3),


                            });
                        }
                    }
                }
            }

            return Lecture;
        }


        public void AddLecture(Lecture lecture)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Lecture (Name, Address, Subject) VALUES (@name, @address, @subject,);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@name", lecture.Name);
                    cmd.Parameters.AddWithValue("@address", lecture.Address);
                    cmd.Parameters.AddWithValue("@subject", lecture.Subject);
                    cmd.ExecuteNonQuery();
      

                }
            }
        }


        public void UpdateLecture(int Lec_id, Lecture lecture)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Lecture (Name, Address, Subject) VALUES (@name, @address, @subject,);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@name", lecture.Name);
                    cmd.Parameters.AddWithValue("@address", lecture.Address);
                    cmd.Parameters.AddWithValue("@subject", lecture.Subject);
                    cmd.ExecuteNonQuery();


                }

            }
        }




        public void DeleteLecture(int Lec_id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Lecture WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", Lec_id);
                }
            }
        }


    }
}



                                  

