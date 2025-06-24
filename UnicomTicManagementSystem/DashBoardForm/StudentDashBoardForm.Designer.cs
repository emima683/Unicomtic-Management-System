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
            this.btn_Mark = new System.Windows.Forms.Button();
            this.btn_Timetable = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_Exam);
            this.panel2.Controls.Add(this.btn_Mark);
            this.panel2.Controls.Add(this.btn_Timetable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 416);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 416);
            this.panel3.TabIndex = 2;
            // 
            // btn_Mark
            // 
            this.btn_Mark.FlatAppearance.BorderSize = 0;
            this.btn_Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mark.Location = new System.Drawing.Point(32, 52);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(127, 44);
            this.btn_Mark.TabIndex = 0;
            this.btn_Mark.Text = "View Mark";
            this.btn_Mark.UseVisualStyleBackColor = true;
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
            // 
            // btn_Timetable
            // 
            this.btn_Timetable.FlatAppearance.BorderSize = 0;
            this.btn_Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timetable.Location = new System.Drawing.Point(18, 127);
            this.btn_Timetable.Name = "btn_Timetable";
            this.btn_Timetable.Size = new System.Drawing.Size(141, 41);
            this.btn_Timetable.TabIndex = 1;
            this.btn_Timetable.Text = "View Timetable";
            this.btn_Timetable.UseVisualStyleBackColor = true;
            this.btn_Timetable.Click += new System.EventHandler(this.btn_Timetable_Click);
            // 
            // btn_Exam
            // 
            this.btn_Exam.FlatAppearance.BorderSize = 0;
            this.btn_Exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exam.Location = new System.Drawing.Point(32, 202);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(124, 43);
            this.btn_Exam.TabIndex = 2;
            this.btn_Exam.Text = "View Exam";
            this.btn_Exam.UseVisualStyleBackColor = true;
            this.btn_Exam.Click += new System.EventHandler(this.btn_Exam_Click);
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
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_Timetable;
        private System.Windows.Forms.Button btn_Mark;
    }
}