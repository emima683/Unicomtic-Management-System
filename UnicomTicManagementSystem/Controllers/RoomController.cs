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
    internal class RoomController
    {
        public List<Room> GetAllRooms()
        {
            List<Room> room = new List<Room>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Room ;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            room.Add(new Room
                            {
                               RoomName = reader.GetString(1),
                               RoomType = reader.GetString(2),
                               Id = reader.GetInt32(3)

                            });
                        }
                    }
                }
                return null;
            }
        }


        public Room Get_room_id(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Room WHERE ID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Room
                            {
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2),
                                Id = reader.GetInt32(3)

                            };

                        }
                    }
                }
            }

            return null;
        }




        public void AddRoom(Room room)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Room (Id, RoomName, RoomType) VALUES (@id, @roomName, @roomType,);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id", room.Id);
                    cmd.Parameters.AddWithValue("@roomName", room.RoomName);
                    cmd.Parameters.AddWithValue("@roomType", room.RoomType);
                  
                    cmd.ExecuteNonQuery();





                }
            }
        }



        public void UpdateRoom(Room room)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Timetable (TimetableId, TimetableSlot, SubjectId, RoomId) VALUES (@timetableId, @timetableSlot, @subjectId, @roomId);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", room.Id);
                    cmd.Parameters.AddWithValue("@roomName", room.RoomName);
                    cmd.Parameters.AddWithValue("@roomType", room.RoomType);

                    cmd.ExecuteNonQuery();


                }

            }
        }




        public void DeleteRoom(int room_Id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Room WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", room_Id);
                }
            }
        }




    }
}
    

