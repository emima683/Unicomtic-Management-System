using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class LectureForm : Form
    {
        private LectureController lectureController = new LectureController();
        private int Lec_id = -1;
        public LectureForm()
        {
            InitializeComponent();
            get_Lecture_info();
        }

        private void get_Lecture_info()
        {
            Lecture_DGV.DataSource = null;
            Lecture_DGV.DataSource = lectureController.show_Output();
            Lecture_DGV.ClearSelection();
            Clear_Inputs();
        }

        private void Clear_Inputs()
        {
            txt_Name.Text = string.Empty;
            txt_Address.Text = string.Empty;
            combo_Subject.Text = string.Empty;
            Lec_id = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_Name.Text) ||
                string.IsNullOrWhiteSpace(lbl_Address.Text) ||
                string.IsNullOrWhiteSpace(combo_Subject.Text))

            {
                MessageBox.Show("please Enter the Name, Address, Subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lecture lecture = new Lecture
            {
                Name  = txt_Name.Text,
                Address = txt_Address.Text,
                Subject = combo_Subject.Text,
                
            };
            LectureController lectureController = new LectureController();

            get_Lecture_info();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Lecture_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("please Select the Lecture to update .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(lbl_Name.Text) ||
                string.IsNullOrWhiteSpace(lbl_Address.Text) ||
                string.IsNullOrWhiteSpace(combo_Subject.Text))
            {
                MessageBox.Show("please Enter the Name, Address, Subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            {
                int stu_id = Convert.ToInt32(Lecture_DGV.SelectedRows[0].Cells["ID"].Value);

                Lecture lecture = new Lecture
                {
                    Name = txt_Name.Text,
                    Address = txt_Address.Text,
                    Subject = combo_Subject.Text,

                };

                LectureController lectureController = new LectureController();


                get_Lecture_info();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lecture_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lecture to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int time_I = Convert.ToInt32(Lecture_DGV.SelectedRows[0].Cells["LectureId"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this Lecture?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lectureController.DeleteLecture(Lec_id);
                get_Lecture_info();
                Clear_Inputs(); ;
            }
        }
    }
}
