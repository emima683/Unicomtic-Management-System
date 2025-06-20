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
        
        private int Exam_id = -1;

        public ExamForm()
        {
            InitializeComponent();
      
            Exam_DGV.CellClick += Exam_DGV_CellClick;  // Use CellClick instead of CellContentClick
        }

        private  void ExamForm_Load(object sender, EventArgs e)
        {
          
            
        }

        private void LoadExam()
        {
            var exam = examController.GetAllExam();
            comboBox_Subject.DataSource = null;
            comboBox_Subject.DisplayMember = "SubjectName";
            comboBox_Subject.ValueMember = "SubjectId";
            comboBox_Subject.SelectedIndex = -1;
        }

        private void LoadExams()
        {
          this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string examName = txtE_Name.Text.Trim();

            if (string.IsNullOrWhiteSpace(examName) || comboBox_Subject.SelectedValue == null)
            {
                MessageBox.Show("Please enter exam name and select a subject.");
                return;
            }

            int Exam_id = Convert.ToInt32(comboBox_Subject.SelectedValue);

            try
            {
                 examController.AddExam(new Exam
                {
                    ExamName = examName,
                    SubjectId = Exam_id
                 });

                txtE_Name.Clear();
                LoadExams();
                MessageBox.Show("Exam Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding exam: {ex.Message}");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Exam_id == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            try
            {
                 examController.UpdateExam(new Exam
                {
                    ExamId = Exam_id,
                    ExamName = txtE_Name.Text.Trim(),
                    SubjectId = Convert.ToInt32(comboBox_Subject.SelectedValue)
                });

                ClearForm();
                LoadExams();
                MessageBox.Show("Exam Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating exam: {ex.Message}");
            }
        }

        private  void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Exam_id == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

           examController.DeleteExam(Exam_id);
           LoadExam();
        }

        private void Exam_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = Exam_DGV.Rows[e.RowIndex];
            if (row.Cells["ExamId"].Value == null || row.Cells["SubjectId"].Value == null)
                return;

            Exam_id = Convert.ToInt32(row.Cells["ExamId"].Value);
            txtE_Name.Text = row.Cells["ExamName"].Value?.ToString() ?? "";
            comboBox_Subject.SelectedValue = Convert.ToInt32(row.Cells["SubjectId"].Value);
        }

        private void ClearForm()
        {
            txtE_Name.Clear();
            comboBox_Subject.SelectedIndex = -1;
            Exam_id = -1;
        }
    }
}

