﻿using System;
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
    public partial class LectureDashBoardForm : Form
    {
        public LectureDashBoardForm()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnV_Course_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            loadFormInPanel(courseForm);
        }

        private void btnV_Timetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            loadFormInPanel(timetableForm);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
