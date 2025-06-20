namespace UnicomTicManagementSystem.Views
{
    partial class TimetableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Select_Sub = new System.Windows.Forms.Label();
            this.lbl_Time_Slot = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.combo_Select = new System.Windows.Forms.ComboBox();
            this.combo_Room = new System.Windows.Forms.ComboBox();
            this.txt_TimeSlot = new System.Windows.Forms.TextBox();
            this.lbl_Timetable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Select_Sub
            // 
            this.lbl_Select_Sub.AutoSize = true;
            this.lbl_Select_Sub.Location = new System.Drawing.Point(254, 56);
            this.lbl_Select_Sub.Name = "lbl_Select_Sub";
            this.lbl_Select_Sub.Size = new System.Drawing.Size(76, 13);
            this.lbl_Select_Sub.TabIndex = 0;
            this.lbl_Select_Sub.Text = "Select Subject";
            // 
            // lbl_Time_Slot
            // 
            this.lbl_Time_Slot.AutoSize = true;
            this.lbl_Time_Slot.Location = new System.Drawing.Point(254, 96);
            this.lbl_Time_Slot.Name = "lbl_Time_Slot";
            this.lbl_Time_Slot.Size = new System.Drawing.Size(51, 13);
            this.lbl_Time_Slot.TabIndex = 1;
            this.lbl_Time_Slot.Text = "Time Slot";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Location = new System.Drawing.Point(254, 135);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(35, 13);
            this.lbl_Room.TabIndex = 2;
            this.lbl_Room.Text = "Room";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(280, 176);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(385, 176);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(495, 176);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // combo_Select
            // 
            this.combo_Select.FormattingEnabled = true;
            this.combo_Select.Location = new System.Drawing.Point(394, 48);
            this.combo_Select.Name = "combo_Select";
            this.combo_Select.Size = new System.Drawing.Size(186, 21);
            this.combo_Select.TabIndex = 6;
            // 
            // combo_Room
            // 
            this.combo_Room.FormattingEnabled = true;
            this.combo_Room.Location = new System.Drawing.Point(394, 127);
            this.combo_Room.Name = "combo_Room";
            this.combo_Room.Size = new System.Drawing.Size(186, 21);
            this.combo_Room.TabIndex = 7;
            // 
            // txt_TimeSlot
            // 
            this.txt_TimeSlot.Location = new System.Drawing.Point(394, 89);
            this.txt_TimeSlot.Name = "txt_TimeSlot";
            this.txt_TimeSlot.Size = new System.Drawing.Size(186, 20);
            this.txt_TimeSlot.TabIndex = 8;
            this.txt_TimeSlot.TextChanged += new System.EventHandler(this.txt_TimeSlot_TextChanged);
            // 
            // lbl_Timetable
            // 
            this.lbl_Timetable.AutoSize = true;
            this.lbl_Timetable.Location = new System.Drawing.Point(358, 24);
            this.lbl_Timetable.Name = "lbl_Timetable";
            this.lbl_Timetable.Size = new System.Drawing.Size(53, 13);
            this.lbl_Timetable.TabIndex = 9;
            this.lbl_Timetable.Text = "Timetable";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 217);
            this.dataGridView1.TabIndex = 10;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Timetable);
            this.Controls.Add(this.txt_TimeSlot);
            this.Controls.Add(this.combo_Room);
            this.Controls.Add(this.combo_Select);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Room);
            this.Controls.Add(this.lbl_Time_Slot);
            this.Controls.Add(this.lbl_Select_Sub);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Select_Sub;
        private System.Windows.Forms.Label lbl_Time_Slot;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox combo_Select;
        private System.Windows.Forms.ComboBox combo_Room;
        private System.Windows.Forms.TextBox txt_TimeSlot;
        private System.Windows.Forms.Label lbl_Timetable;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}