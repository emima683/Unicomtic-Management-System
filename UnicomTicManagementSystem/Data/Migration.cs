using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
                                CREATE TABLE IF NOT EXISTS User (ID INTEGER PRIMARY KEY AUTOINCREMENT, Role TEXT, UserName TEXT, Password STRING);

                                CREATE TABLE IF NOT EXISTS Student (StudentID INTEGER PRIMARY KEY AUTOINCREMENT, First_Name TEXT, Last_Name TEXT, Address STRING, Stream STRING);

                                CREATE TABLE IF NOT EXISTS Lecture (LectureID INTEGER PRIMARY KEY AUTOINCREMENT, LectureNmae TEXT NOT NULL, Address TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Mark  (MarkID INTEGER PRIMARY KEY AUTOINCREMENT, StudentID INTEGER, ExamID INTEGER,Score INTEGER, FOREIGN KEY(StudentID) REFERENCES Student(StudentID), FOREIGN KEY(ExamID) REFERENCES Exam(ExamID));

                                CREATE TABLE IF NOT EXISTS Timetable (TimetableID INTEGER PRIMARY KEY AUTOINCREMENT, TimeSlot TEXT NOT NULL, SubjectID INTEGER NOT  NULL, RoomID INTEGER NOT NULL, FOREIGN KEY(SubjectId) REFERENCES Subject(SubjectId), FOREIGN KEY(RoomId) REFERENCES Exam(RoomId));

                                CREATE TABLE IF NOT EXISTS Course (CourseID INTEGER PRIMARY KEY AUTOINCREMENT, CourseName TEXT NOT NULL, Start DATE NOT NULL, End DATE NOT NULL);

                                CREATE TABLE IF NOT EXISTS Exams (ExamID INTEGER PRIMARY KEY AUTOINCREMENT, ExamName TEXT NOT NULL, SubjectId INTEGER, FOREIGN KEY(SubjectId) REFERENCES Subject(SubjectId));

                                CREATE TABLE IF NOT EXISTS Room (RoomID INTEGER PRIMARY KEY AUTOINCREMENT, RoomName TEXT NOT NULL, RoomType TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Subject (SubjectID INTEGER PRIMARY KEY AUTOINCREMENT, SubjectName TEXT, CourseID INTEGER, FOREIGN KEY(CourseID) REFERENCES Course(CourseID));

                                



                               ";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.ExecuteNonQuery();
                }


            }

        }
    }
}
