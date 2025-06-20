using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Views;

namespace UnicomTicManagementSystem.DashBoardForm
{
    public partial class AdminDashBoardForm : Form
    {
        public AdminDashBoardForm()
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
            LoginForm loginForm = new LoginForm();
            loadFornInPanel(loginForm);
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
    }
}
