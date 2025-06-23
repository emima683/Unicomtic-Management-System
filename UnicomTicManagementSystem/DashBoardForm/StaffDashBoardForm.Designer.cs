namespace UnicomTicManagementSystem.DashBoardForm
{
    partial class StaffDashBoardForm
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Mark = new System.Windows.Forms.Button();
            this.btn_Timetable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 414);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.btn_Logout);
            this.panel3.Controls.Add(this.btn_Mark);
            this.panel3.Controls.Add(this.btn_Timetable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 414);
            this.panel3.TabIndex = 3;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(40, 224);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(88, 36);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_Mark
            // 
            this.btn_Mark.FlatAppearance.BorderSize = 0;
            this.btn_Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mark.Location = new System.Drawing.Point(40, 53);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(111, 35);
            this.btn_Mark.TabIndex = 1;
            this.btn_Mark.Text = "View Mark";
            this.btn_Mark.UseVisualStyleBackColor = true;
            // 
            // btn_Timetable
            // 
            this.btn_Timetable.FlatAppearance.BorderSize = 0;
            this.btn_Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timetable.Location = new System.Drawing.Point(25, 143);
            this.btn_Timetable.Name = "btn_Timetable";
            this.btn_Timetable.Size = new System.Drawing.Size(145, 46);
            this.btn_Timetable.TabIndex = 0;
            this.btn_Timetable.Text = "View Timetable";
            this.btn_Timetable.UseVisualStyleBackColor = true;
            // 
            // StaffDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StaffDashBoardForm";
            this.Text = "StaffDashBoardForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Mark;
        private System.Windows.Forms.Button btn_Timetable;
        private System.Windows.Forms.Panel panel3;
    }
}