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
    public partial class StudentForm : Form
    {
       private StudentController studentController = new StudentController();
       private int stu_id = -1;
        public StudentForm()
        {
            InitializeComponent();
            get_student_info();
        }

        private void get_student_info ()
        {
            Student_DGV.DataSource = null;
            Student_DGV.DataSource = studentController.show_Output();
            Student_DGV.ClearSelection();
            Clear_Inputs();
        }

        private void Clear_Inputs()
        {
            textBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            stu_id = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblF_Name.Text)|| 
                string.IsNullOrWhiteSpace(lblL_Name.Text)||
                string.IsNullOrWhiteSpace(lblAddress.Text))

            {
                MessageBox.Show("please Enter the First_Name, Last_Name, Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student student = new Student
            {
                First_Name = textBox3.Text,
                Last_Name = textBox1.Text,
                Address = textBox2.Text,
                Stream = comboBox1.Text,
            };
            StudentController studentController = new StudentController(student);

            get_student_info();
            
         
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(Student_DGV.SelectedRows.Count==0)
            {
                MessageBox.Show("please Select the student to update .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
                if (string.IsNullOrWhiteSpace(lblF_Name.Text) || 
                string.IsNullOrWhiteSpace(lblL_Name.Text) || 
                string.IsNullOrWhiteSpace(lblAddress.Text))
            {
                MessageBox.Show("please Enter the First_Name, Last_Name, Address, and Sream.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            {
               int stu_id = Convert.ToInt32(Student_DGV.SelectedRows[0].Cells["ID"].Value);
                
                Student student = new Student
                {
                    First_Name = textBox3.Text,
                    Last_Name = textBox1.Text,
                    Address = textBox2.Text,
                    Stream = comboBox1.Text,
                    Id = stu_id
                };
               StudentController studentController = new StudentController();
                          
                
                get_student_info();
            }
        }

        private void Student_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Student_DGV.SelectedRows.Count > 0)
            {
                var row = Student_DGV.SelectedRows[0];
                var student = (Student)row.DataBoundItem;

                stu_id = student.Id;
                textBox3.Text = student.First_Name;
                textBox1.Text = student.Last_Name;
                textBox2.Text = student.Address;
                comboBox1.Text = student.Stream;
            }
            else
            {
                Clear_Inputs();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("FullStock in Engineering");
            comboBox1.Items.Add("BSc in Cyber");
            comboBox1.Items.Add("BSc in Machine Language");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Student_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a timetable to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int time_I = Convert.ToInt32(Student_DGV.SelectedRows[0].Cells["StudentId"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                studentController.DeleteStudent(stu_id);
                get_student_info();
                Clear_Inputs(); ;
            }
        }
    }
}
