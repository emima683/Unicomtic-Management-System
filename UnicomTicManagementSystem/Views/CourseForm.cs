using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class CourseForm : Form
    {
        private CourseController courseController = new CourseController();
        private int Clicked_Id = -1;
        public CourseForm()
        {
            InitializeComponent();
            this.Load += CourseForm_Load();
        }

        private async void Course_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Course_DGV.Rows[e.RowIndex];
                Clicked_Id = Convert.ToInt32(row.Cells["Course_Id"].Value);
                txt_Course.Text = row.Cells["CourseName"].Value.ToString();
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            if (Clicked_Id != -1)
            {
                courseController.UpdateAsync(new Course
                {
                    Id = Clicked_Id,
                    CourseName = txt_Course.Text.Trim(),
                });

                txt_Course.Clear();
                Clicked_Id = -1;
                await LoadCourses();
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Course.Text;
            DateTime Startdate = dateTimePicker1.Value;
            DateTime Enddate = dateTimePicker1.Value;

            if (!string.IsNullOrWhiteSpace(name))
            {
                courseController.AddAsync(new Course
                {
                    CourseName = name,
                    StartDate = Startdate,
                    EndDate = Enddate,  

                });

                txt_Course.Clear();
                await LoadCourses();
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Clicked_Id != -1)
            {
                courseController.DeleteAsync(Clicked_Id);
                txt_Course.Clear();
                Clicked_Id = -1;
                await LoadCourses();
            }
        }

        private void txt_Course_TextChanged(object sender, EventArgs e)
        {

        }

        private async void CourseForm_Load(object sender, EventArgs e)
        {
            await LoadCourses();
        }

        private async Task LoadCourses()
        {
            Course_DGV.DataSource = await CourseController.GetAllCourseAsync();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
