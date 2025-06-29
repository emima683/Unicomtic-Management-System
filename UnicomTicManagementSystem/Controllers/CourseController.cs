﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class CourseController
    {
        public async Task <List<Course>>  GetAllCourseAsync()
        {
            List<Course> course = new List<Course>();  
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Course;";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                 {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            course.Add(new Course
                            {
                                Id = reader.GetInt32(0),
                                CourseName = reader.GetString(1),
                                StartDate = reader.GetDateTime(2),
                                EndDate = reader.GetDateTime(3),
                            });
                        }

                    }


                }
                    
            }

                return course;  

        }


        public async void AddAsync (Course course)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Course (CourseName, StartDate, EndDate) VALUES (@name, @startDate, @endDate);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.Parameters.AddWithValue("@startDate", course.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", course.EndDate);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdateAsync(Course course)
        {
            using (var conn = DBConfig.GetConnection())
            { 
                string query = "INSERT INTO Course (CourseName = @name, StartDate = @startDate, EndDate = @endDate)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.Parameters.AddWithValue("@startDate", course.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", course.EndDate);
                    cmd.Parameters.AddWithValue("@id", course.Id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async void DeleteAsync (int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Course WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
                    
        }

    }
}
