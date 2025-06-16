using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    internal class StudentController
    {
        public StudentController() { }

        public StudentController(Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Student (First_Name, Last_Name, Address, Stream) VALUES (@first_Name, @last_Name, @address, @stream);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_Name", student.First_Name);
                    cmd.Parameters.AddWithValue("@last_Name", student.Last_Name);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.Parameters.AddWithValue("@stream", student.Stream);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Add sucessful!!!");
                }
            }
        }


        public List<Student> show_Output()
        {
            List<Student> students = new List<Student>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Student ;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2),
                                Address = reader.GetString(3),
                                Stream = reader.GetString(4),

                            });




                        }
                    }
                }
                return students;
            }
        }


        public Student Get_student_id(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Student WHERE ID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2),
                                Address = reader.GetString(3),
                                Stream = reader.GetString(4),
                            };

                        }
                    }
                }
            }

            return null;
        }




        public void AddStudent(Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Student (First_Name, Last_Name, Address, Stream) VALUES (@first_Name, @last_Name, @address, @stream);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@first_Name", student.First_Name);
                    cmd.Parameters.AddWithValue("@last_Name", student.Last_Name);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.Parameters.AddWithValue("@stream", student.Stream);
                    cmd.ExecuteNonQuery();





                }
            }
        }



        public void UpdateStudent(int stu_id, Student student  )
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Student (First_Name, Last_Name, Address, Stream) VALUES (@first_Name, @last_Name, @address, @stream);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@first_Name", student.First_Name);
                    cmd.Parameters.AddWithValue("@last_Name", student.Last_Name);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.Parameters.AddWithValue("@stream", student.Stream);
                    cmd.ExecuteNonQuery();



                }

            }
        }

        


        public void DeleteStudent(int Stu_id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Student WHERE Id = @Id";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(@"Id", Stu_id);
                }
            }
        }

            


    }

}