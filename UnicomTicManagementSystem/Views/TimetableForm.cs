using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class TimetableForm : Form
    {
        private TimetableController timetableController = new TimetableController();
        private int time_Id = -1;

        public TimetableForm()
        {
            InitializeComponent();
            get_Timetable_info();
        }

        private void get_Timetable_info()
        {
            Timetable_DGV.DataSource = null;
            Timetable_DGV.DataSource = timetableController.GetAllTimetables();
            Timetable_DGV.ClearSelection();
        }

        private void ClearInputs()
        {
            textBox1.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            time_Id = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the Subject, TimeSlot, and Room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Timetable timetable = new Timetable
            {
                TimetableSlot = textBox1.Text,
                SubjectId = comboBox1.SelectedIndex, 
                RoomId = comboBox2.SelectedIndex
            };

            timetableController.AddTimetable(timetable);
            get_Timetable_info();
            ClearInputs();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Timetable_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the timetable to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the Subject, TimeSlot, and Room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = Convert.ToInt32(Timetable_DGV.SelectedRows[0].Cells["TimetableId"].Value);

            Timetable timetable = new Timetable
            {
                TimetableId = selectedId,
                TimetableSlot = textBox1.Text,
                SubjectId = comboBox1.SelectedIndex,
                RoomId = comboBox2.SelectedIndex
            };

            timetableController.UpdateTimetable(selectedId, timetable);
            get_Timetable_info();
            ClearInputs();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Timetable_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a timetable to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int time_I = Convert.ToInt32(Timetable_DGV.SelectedRows[0].Cells["TimetableId"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                timetableController.DeleteTimetable(time_I);
                get_Timetable_info();
                ClearInputs();
            }
        }
    }
}
