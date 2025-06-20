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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{

    public partial class SubjectForm : Form
    {
       private  SubjectController subjectController = new SubjectController();
        private int sub_id = -1;
        public SubjectForm()
        {
            InitializeComponent();
            get_Subject_info();
        }

        private void get_Subject_info()
        {
            Subject_DGV.DataSource = null;
            Subject_DGV.DataSource = subjectController.GetAllSubjects();
            Subject_DGV.ClearSelection();

        }

        private void Clear_Inputs()
        {
            textBox1.Text = string.Empty;
            combo_course.SelectedIndex = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(combo_course.Text))
            {
                MessageBox.Show("Please enter the SubjectName and Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subject newsubject = new Subject();

            newsubject.SubjectName = textBox1.Text;
            newsubject.Id = combo_course.TabIndex; 

            subjectController.AddSubject(newsubject); 

            get_Subject_info();
            Clear_Inputs();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Subject_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the subject to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fix missing closing parenthesis here and also fix the check to use textBox1 and comboBox1
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(combo_course.Text))
            {
                MessageBox.Show("Please enter the SubjectName and Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sub_id = Convert.ToInt32(Subject_DGV.SelectedRows[0].Cells["ID"].Value);

            Subject subject = new Subject
            {
                SubjectName = textBox1.Text,
                Course = combo_course.TabIndex, // Again, convert to int if needed
                Id = sub_id
            };

            subjectController.UpdateSubject(subject); // fixed variable name (was updatedSubject)
            get_Subject_info();
            Clear_Inputs();


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Subject_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sub_id = Convert.ToInt32(Subject_DGV.SelectedRows[0].Cells["ID"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                subjectController.DeleteSubject(sub_id);
                get_Subject_info();
                Clear_Inputs();
            }

        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
