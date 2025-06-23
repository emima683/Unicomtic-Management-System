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
    public partial class RoomForm : Form
    {
        private RoomController roomController = new RoomController();
        private int room_Id = -1;

        public RoomForm()
        {
            InitializeComponent();
            get_Room_info();
        }

        private void get_Room_info()
        {
            Room_DGV.DataSource = null;
            Room_DGV.DataSource = roomController.GetAllRooms();
            Room_DGV.ClearSelection();
        }

        private void ClearInputs()
        {
            txt_RoomName.Text = string.Empty;
            combo_RoomType.TabIndex = 0;
            room_Id = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RoomName.Text) ||
                combo_RoomType.SelectedIndex == -1 )
               
            {
                MessageBox.Show("Please enter the .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Room room = new Room
            {
                RoomName = txt_RoomName.Text,
                RoomType = combo_RoomType.Text,
                Id = room_Id
               
            };

            roomController.AddRoom(room);
            get_Room_info();
            ClearInputs();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Room_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the timetable to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_RoomName.Text) ||
                combo_RoomType.SelectedIndex == -1 )
               
            {
                MessageBox.Show("Please enter the Subject, TimeSlot, and Room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = Convert.ToInt32(Room_DGV.SelectedRows[0].Cells["TimetableId"].Value);

            Room room = new Room
            {

                RoomName = txt_RoomName.Text,
                RoomType = combo_RoomType.Text,
                Id = room_Id
            };

            roomController.UpdateRoom(room);
            get_Room_info();
            ClearInputs();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Room_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a timetable to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int time_I = Convert.ToInt32(Room_DGV.SelectedRows[0].Cells["TimetableId"].Value);

            var result = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                roomController.DeleteRoom(room_Id);
                get_Room_info();
                ClearInputs(); ;
            }
        }
    }
}
