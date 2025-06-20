namespace UnicomTicManagementSystem.DashBoardForm
{
    partial class LectureDashBoardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnV_Course = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btnV_Timetable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.btnV_Timetable);
            this.panel2.Controls.Add(this.btnV_Course);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 419);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(178, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 419);
            this.panel3.TabIndex = 2;
            // 
            // btnV_Course
            // 
            this.btnV_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnV_Course.FlatAppearance.BorderSize = 0;
            this.btnV_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV_Course.Location = new System.Drawing.Point(12, 55);
            this.btnV_Course.Name = "btnV_Course";
            this.btnV_Course.Size = new System.Drawing.Size(160, 50);
            this.btnV_Course.TabIndex = 0;
            this.btnV_Course.Text = "View Course";
            this.btnV_Course.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(49, 195);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(74, 48);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btnV_Timetable
            // 
            this.btnV_Timetable.FlatAppearance.BorderSize = 0;
            this.btnV_Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV_Timetable.Location = new System.Drawing.Point(22, 126);
            this.btnV_Timetable.Name = "btnV_Timetable";
            this.btnV_Timetable.Size = new System.Drawing.Size(134, 50);
            this.btnV_Timetable.TabIndex = 2;
            this.btnV_Timetable.Text = "View Timetable";
            this.btnV_Timetable.UseVisualStyleBackColor = true;
            // 
            // LectureDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LectureDashBoardForm";
            this.Text = "LectureDashBoardForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnV_Timetable;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btnV_Course;
    }
}