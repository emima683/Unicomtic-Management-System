using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class TimetableController
    {
        public List<Timetable> show_Output()
        {
            List<Timetable> timetable = new List<Timetable>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Timetable ;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            timetable.Add(new Timetable
                            {
                                TimetableId = reader.GetInt32(0),
                                TimetableSlot = reader.GetString(1),
                                SubjectId = reader.GetInt32(2),
                                RoomId = reader.GetInt32(3),


                            });
                        }
                    }
                }
                return timetable;
            }
        }


        public Timetable Get_student_id(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Timetable WHERE ID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Timetable
                            {
                                TimetableId = reader.GetInt32(0),
                                TimetableSlot = reader.GetString(1),
                                SubjectId = reader.GetInt32(2),
                                RoomId = reader.GetInt32(3),
                               
                            };

                        }
                    }
                }
            }

            return null;
        }




        public void AddTimetable(Timetable timetable)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Timetable (TimetableId, TimetableSlot, SubjectId, RoomId) VALUES (@timetableId, @timetableSlot, @subjectId, @roomId);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@timetableId", timetable.TimetableId);
                    cmd.Parameters.AddWithValue("@timetableSlot", timetable.TimetableSlot);
                    cmd.Parameters.AddWithValue("@subjectId", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomId);
                    cmd.ExecuteNonQuery();





                }
            }
        }



        public void UpdateTimetable(int stu_id, Timetable timetable)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Timetable (TimetableId, TimetableSlot, SubjectId, RoomId) VALUES (@timetableId, @timetableSlot, @subjectId, @roomId);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@timetableIde", timetable.TimetableId);
                    cmd.Parameters.AddWithValue("@timetableSlot", timetable.TimetableSlot);
                    cmd.Parameters.AddWithValue("@subjectId", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomId);
                    cmd.ExecuteNonQuery();



                }

            }
        }




        public void DeleteTimetable(int time_id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Timetable WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", time_id);
                }
            }
        }




    }
}
