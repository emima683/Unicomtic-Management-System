using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class ExamForm : Form
    {
        private ExamController examController = new ExamController();
        private SubjectController subjectController = new SubjectController();
        private int Clicked_ExamId = -1;


        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
            
        }

        private async void ExamForm_Load(object sender, EventArgs e)
        {
            await LoadExams();
            await LoadSubjects();
        }

        private async Task LoadSubjects()
        {
            var subjects = await subjectController.GetAllSubjectsAsync();
            cmb_sub.DataSource = subjects;
            cmb_sub.DisplayMember = "SubjectName";
            cmb_sub.ValueMember = "SubjectId";

        }


        private async Task LoadExams()
        {
            Exam_DGV.DataSource = await examController.GetAllExamAsync();
        }

        private void ExamForm_Load_1(object sender, EventArgs e)
        {

        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            string examName = txtE_Name.Text.Trim();
            int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

            if(!string.IsNullOrWhiteSpace(examName))
            {
                await examController.AddAsync (new Exam
                    {
                        ExamName = examName,
                        SubjectId = subjectId
                    });
                txtE_Name.Clear();
                await LoadExams();

                MessageBox.Show("Exam Addeda Succesfully");
            }

            else
            {
                MessageBox.Show("Please enter exam name");
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            if (Clicked_ExamId != -1)
            {
                await examController.UpdateAsync(new Exam
                {
                    ExamId = Clicked_ExamId,
                    ExamName = txtE_Name.Text.Trim(),
                    SubjectId = Convert.ToInt32(cmb_sub.SelectedValue)

                });

                txtE_Name.Clear();
                Clicked_ExamId = -1;
                await LoadExams();
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Clicked_ExamId != -1)
            {
                await examController.DeleteAsync(Clicked_ExamId);
                txtE_Name.Clear();
                Clicked_ExamId = -1; 
                await LoadExams();
                
            }
        }

        private void Exam_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = Exam_DGV.Rows[e.RowIndex];
                Clicked_ExamId = Convert.ToInt32(row.Cells["ExamId"].Value);
                txtE_Name.Text = row.Cells["ExamName"].Value.ToString();
                cmb_sub.SelectedValue = row.Cells["SubjectId"].Value;
            }
        }
    }
}
