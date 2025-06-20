using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class ExamController
    {
        public List<Exam> GetAllExam()
        {
            List<Exam> exam = new List<Exam>();

            using (var conn = DBConfig.GetConnection())
            {
              
                string query = @"SELECT * FROM Exam;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exam.Add(new Exam
                            {
                                ExamId = reader.GetInt32(0),
                                ExamName = reader.GetString(1),
                                SubjectId = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }

            return exam;
        }

        public void AddExam (Exam exam)
        {
            using (var conn = DBConfig.GetConnection())
            {
          
                string query = "INSERT INTO Exam (ExamName, SubjectId) VALUES (@name, @subjectId);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateExam(Exam exam)
        {
            using (var conn = DBConfig.GetConnection())
            {
              
                string query = "UPDATE Exam SET ExamName = @name, SubjectId = @subjectId WHERE ExamId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectId);
                    cmd.Parameters.AddWithValue("@id", exam.ExamId);
                     cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteExam(int examid)
        {
            using (var conn = DBConfig.GetConnection())
            {

                string query = "DELETE FROM Exam WHERE ExamId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", examid);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
