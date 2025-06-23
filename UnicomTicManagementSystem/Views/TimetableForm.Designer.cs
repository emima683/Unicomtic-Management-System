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
            this.Timetable_DGV = new System.Windows.Forms.DataGridView();
            this.lblt_Table = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.lblS_Subject = new System.Windows.Forms.Label();
            this.lblT_Slot = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetable_DGV
            // 
            this.Timetable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetable_DGV.Location = new System.Drawing.Point(125, 203);
            this.Timetable_DGV.Name = "Timetable_DGV";
            this.Timetable_DGV.Size = new System.Drawing.Size(579, 235);
            this.Timetable_DGV.TabIndex = 0;
            // 
            // lblt_Table
            // 
            this.lblt_Table.AutoSize = true;
            this.lblt_Table.Location = new System.Drawing.Point(352, 9);
            this.lblt_Table.Name = "lblt_Table";
            this.lblt_Table.Size = new System.Drawing.Size(57, 13);
            this.lblt_Table.TabIndex = 1;
            this.lblt_Table.Text = "TimeTable";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Location = new System.Drawing.Point(248, 127);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(35, 13);
            this.lbl_Room.TabIndex = 2;
            this.lbl_Room.Text = "Room";
            // 
            // lblS_Subject
            // 
            this.lblS_Subject.AutoSize = true;
            this.lblS_Subject.Location = new System.Drawing.Point(248, 49);
            this.lblS_Subject.Name = "lblS_Subject";
            this.lblS_Subject.Size = new System.Drawing.Size(79, 13);
            this.lblS_Subject.TabIndex = 3;
            this.lblS_Subject.Text = "Select_Subject";
            // 
            // lblT_Slot
            // 
            this.lblT_Slot.AutoSize = true;
            this.lblT_Slot.Location = new System.Drawing.Point(248, 90);
            this.lblT_Slot.Name = "lblT_Slot";
            this.lblT_Slot.Size = new System.Drawing.Size(54, 13);
            this.lblT_Slot.TabIndex = 4;
            this.lblT_Slot.Text = "Time_Slot";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(262, 163);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(395, 163);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(519, 163);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(395, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lblT_Slot);
            this.Controls.Add(this.lblS_Subject);
            this.Controls.Add(this.lbl_Room);
            this.Controls.Add(this.lblt_Table);
            this.Controls.Add(this.Timetable_DGV);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Timetable_DGV;
        private System.Windows.Forms.Label lblt_Table;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Label lblS_Subject;
        private System.Windows.Forms.Label lblT_Slot;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}