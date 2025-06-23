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
        private int course_Id = -1;
        public CourseForm()
        {
            InitializeComponent();
            this.Load += CourseForm_Load;
        }

        private async void Course_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Course_DGV.Rows[e.RowIndex];
                course_Id = Convert.ToInt32(row.Cells["Course_Id"].Value);
                combo_Course.Text = row.Cells["CourseName"].Value.ToString();
                await LoadCourses();
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            if (course_Id != -1)
            {
                courseController.UpdateAsync(new Course
                {
                    Id = course_Id,
                    CourseName = combo_Course.Text,
                    StartDate = dateTimePicker1.Value,
                    EndDate = dateTimePicker2.Value,
                });

                combo_Course.SelectedIndex = 0;
                course_Id = -1;
                await LoadCourses();
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            string name = combo_Course.Text;
            DateTime Startdate = dateTimePicker1.Value;
            DateTime Enddate = dateTimePicker1.Value;

            if (!string.IsNullOrWhiteSpace(name))
            {
                courseController.AddAsync(new Course
                {
                    Id = course_Id,
                    CourseName = combo_Course.Text,
                    StartDate = dateTimePicker1. Value ,
                    EndDate = dateTimePicker2. Value ,

                });

                combo_Course.SelectedIndex = 0;
                await LoadCourses();
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }

        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            if (course_Id != -1)
            {
                
                courseController.DeleteAsync(course_Id );
                combo_Course.SelectedIndex = 0;
                course_Id = -1;
                
                
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
            Course_DGV.DataSource = await courseController.GetAllCourseAsync();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
