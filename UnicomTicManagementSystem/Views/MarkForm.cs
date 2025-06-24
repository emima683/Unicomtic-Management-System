using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controller.cs;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class MarkForm : Form
    {
        private MarkController markController = new MarkController();
        private StudentController studentController = new StudentController();
        private ExamController examController = new ExamController();
        private int Clicked_MarkId = -1;
        public MarkForm()
        {
            InitializeComponent();
            this.Load += MarkForm_Load;
            this.Mark_DGV.CellContentClick += Mark_DGV_CellContentClick;
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadExams();
            LoadMark();
        }

        private void LoadStudents()
        {
            var student = studentController.show_Output();
            combo_Student.DataSource = student;
            combo_Student.DisplayMember = "StudentName";
            combo_Student.ValueMember = "StudentId";
        }

        private void LoadExams()
        {
            var exam =examController.GetAllExam();
            combo_Exam.DataSource = exam;
            combo_Exam.DisplayMember = "ExamName";
            combo_Exam.ValueMember = "ExamId";
        }

        private void LoadMark()
        {
            Mark_DGV.DataSource = markController.GetAllMarks();
        }

        private  void btn_Add_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(combo_Student.SelectedValue);
            int examId = Convert.ToInt32(combo_Exam.SelectedValue);
            int score = Convert.ToInt32(txt_Score.Text);

            markController.Add(new Mark
            {
                StudentId = studentId,
                ExamId = examId,
                Score = score
            });

             txt_Score.Clear();
             LoadMark();
        }

        private  void btn_Update_Click(object sender, EventArgs e)
        {
            if (Clicked_MarkId != -1)
            {
                 markController.Update(new Mark
                 {
                    MarkId = Clicked_MarkId,
                    StudentId = Convert.ToInt32(combo_Student.SelectedValue),
                    ExamId = Convert.ToInt32(combo_Exam.SelectedValue),
                    Score = Convert.ToInt32(txt_Score.Text),
                 });

                 txt_Score.Clear();
                 Clicked_MarkId = -1;
                 LoadMark();
            }
        }

        private  void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Clicked_MarkId != -1)
            {
                 markController.Delete(Clicked_MarkId);
                txt_Score.Clear();
                Clicked_MarkId = -1;
                LoadMark();
                
            };
        }

        private void Mark_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = Mark_DGV.Rows[e.RowIndex];
            Clicked_MarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
            combo_Student.SelectedValue = row.Cells["StudentID"].Value;
            combo_Exam.SelectedValue = row.Cells["ExamID"].Value;
            txt_Score.Text = row.Cells["Score"].Value.ToString();
        }
    }
}
