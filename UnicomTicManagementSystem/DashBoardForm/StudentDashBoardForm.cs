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
    public partial class StudentDashBoardForm : Form
    {
        public StudentDashBoardForm()
        {
            InitializeComponent();
        }

        private void loadFormInPanel(Form childForm)
        {
            panel3.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_Mark_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            loadFormInPanel(markForm);
        }

        private void btn_Timetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            loadFormInPanel(timetableForm);
        }

        private void btn_Exam_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(); 
            loadFormInPanel(examForm);
        }
    }
}
