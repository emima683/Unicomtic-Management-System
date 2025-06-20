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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
          
        }

        private void txt_TimeSlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_Select_Sub.Text) || string.IsNullOrWhiteSpace(lbl_Time_Slot.Text) || string.IsNullOrWhiteSpace(lbl_Room.Text))
            {
                MessageBox.Show("please Enter the TimetableId, TimetableSlot, SubjectId, RoomId.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Timetable timetable = new Timetable();
            //newtimetable.TimetableId = textBox3.Text;
           
           

            

        }
    }
}
