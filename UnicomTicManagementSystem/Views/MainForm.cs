using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void loadFornInPanel(Form childForm)
        {
            panel3.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           this .Close();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            loadFornInPanel(studentForm);
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            loadFornInPanel(courseForm);
        }

        private void btn_Exam_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(); 
            loadFornInPanel(examForm);
        }

        private void btn_Mark_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            loadFornInPanel(markForm);
        }

        private void btn_Timetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            loadFornInPanel(timetableForm);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm(); 
            loadFornInPanel(roomForm);  
        }

       // private void btn_Subject_Click(object sender, EventArgs e)
        private void btn_Subject_Click_1(object sender, EventArgs e)
        {
          SubjectForm subjectForm = new SubjectForm();  
            loadFornInPanel(subjectForm);
        }

        private void btn_lecture_Click(object sender, EventArgs e)
        {
            LectureForm lectureForm = new LectureForm();
            loadFornInPanel(lectureForm);
        }
    }

}
