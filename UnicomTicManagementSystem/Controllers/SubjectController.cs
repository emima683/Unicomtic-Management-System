using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class SubjectController
    {
        public SubjectController() { }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (var conn = DBConfig.GetConnection())
            {
              
                string query = @"SELECT * FROM Subject;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader =  cmd.ExecuteReader())
                {
                    while ( reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            Course = reader.GetInt32(2),
                        });
                    }
                }
            }

            return null;
        }

        public  void AddSubject(Subject subject)
        {
            using (var conn = DBConfig.GetConnection())
            {
              
                string query = "INSERT INTO Subject (SubjectName, CourseId) VALUES (@subjectName, @courseId);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.Course);
                     cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = DBConfig.GetConnection())
            {
               
                string query = "UPDATE Subject SET SubjectName = @subjectName, CourseId = @courseId WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.Course);
                    cmd.Parameters.AddWithValue("@id", subject.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public  void DeleteSubject(int subjectId)
        {
            using (var conn = DBConfig.GetConnection())
            {
               
                string query = "DELETE FROM Subject WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Subject GetSubjectById(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
         
                string query = @"SELECT * FROM Subject WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader =  cmd.ExecuteReader())
                    {
                        if ( reader.Read())
                        {
                            return new Subject
                            {
                                Id = reader.GetInt32(0),
                                SubjectName = reader.GetString(1),
                                Course = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
