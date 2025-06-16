using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controller.cs
{
    internal class MarkController
    {
        public async Task<List<Mark>> GetAllMarksAsync()
        {
            List<Mark> mark = new List<Mark>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Mark;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())

                    {
                        while (await reader.ReadAsync())
                        {
                            mark.Add(new Mark
                            {
                                MarkId = reader.GetInt32(0),
                                StudentId = reader.GetInt32(1),
                                ExamId = reader.GetInt32(2),
                                Score = reader.GetInt32(3)
                            });
                                
                                
                        }
                    }
                }
            }

            return mark;
        }


        public async Task AddAsync(Mark mark)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Mark(StudentId, ExamId, Score) VALUE (@studentId, @examId, @score);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                        cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                        cmd.Parameters.AddWithValue("@score", mark.Score);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }

        public async Task UpdateAsync(Mark mark)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Mark SET StudentId=@studentId, ExamId=@examId, Score=@score WHERE Id=@id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                        cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                        cmd.Parameters.AddWithValue("@score", mark.Score);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }


        public async Task DeleteAsync(Mark mark)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE Mark";
            }
            
        }
    }
}
