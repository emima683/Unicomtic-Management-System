namespace UnicomTicManagementSystem.DashBoardForm
{
    partial class StudentDashBoardForm
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
            this.btnV_Mark = new System.Windows.Forms.Button();
            this.btnV_Timetable = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
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
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.btnV_Mark);
            this.panel2.Controls.Add(this.btnV_Timetable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 414);
            this.panel3.TabIndex = 2;
            // 
            // btnV_Mark
            // 
            this.btnV_Mark.FlatAppearance.BorderSize = 0;
            this.btnV_Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV_Mark.Location = new System.Drawing.Point(60, 62);
            this.btnV_Mark.Name = "btnV_Mark";
            this.btnV_Mark.Size = new System.Drawing.Size(75, 23);
            this.btnV_Mark.TabIndex = 0;
            this.btnV_Mark.Text = "View Mark";
            this.btnV_Mark.UseVisualStyleBackColor = true;
            // 
            // btnV_Timetable
            // 
            this.btnV_Timetable.FlatAppearance.BorderSize = 0;
            this.btnV_Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV_Timetable.Location = new System.Drawing.Point(34, 145);
            this.btnV_Timetable.Name = "btnV_Timetable";
            this.btnV_Timetable.Size = new System.Drawing.Size(137, 23);
            this.btnV_Timetable.TabIndex = 1;
            this.btnV_Timetable.Text = "View Timetable";
            this.btnV_Timetable.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(60, 224);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // StudentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashBoardForm";
            this.Text = "StudentDashBoardForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btnV_Timetable;
        private System.Windows.Forms.Button btnV_Mark;
    }
}