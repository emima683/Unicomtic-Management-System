namespace UnicomTicManagementSystem.Views
{
    partial class MainForm
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
            System.Windows.Forms.Button btn_Subject;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Room = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Course = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.btn_Mark = new System.Windows.Forms.Button();
            this.btn_Timetable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_lecture = new System.Windows.Forms.Button();
            btn_Subject = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Subject
            // 
            btn_Subject.FlatAppearance.BorderSize = 0;
            btn_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Subject.Location = new System.Drawing.Point(52, 306);
            btn_Subject.Name = "btn_Subject";
            btn_Subject.Size = new System.Drawing.Size(95, 23);
            btn_Subject.TabIndex = 9;
            btn_Subject.Text = "Subject Form";
            btn_Subject.UseVisualStyleBackColor = true;
            btn_Subject.Click += new System.EventHandler(this.btn_Subject_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_lecture);
            this.panel2.Controls.Add(btn_Subject);
            this.panel2.Controls.Add(this.btn_Room);
            this.panel2.Controls.Add(this.btn_Student);
            this.panel2.Controls.Add(this.btn_Course);
            this.panel2.Controls.Add(this.btn_Exam);
            this.panel2.Controls.Add(this.btn_Mark);
            this.panel2.Controls.Add(this.btn_Timetable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 419);
            this.panel2.TabIndex = 1;
            // 
            // btn_Room
            // 
            this.btn_Room.FlatAppearance.BorderSize = 0;
            this.btn_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Room.Location = new System.Drawing.Point(63, 265);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(75, 23);
            this.btn_Room.TabIndex = 8;
            this.btn_Room.Text = "Room Form";
            this.btn_Room.UseVisualStyleBackColor = true;
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // btn_Student
            // 
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Location = new System.Drawing.Point(49, 61);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(98, 23);
            this.btn_Student.TabIndex = 3;
            this.btn_Student.Text = "Student Form";
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // btn_Course
            // 
            this.btn_Course.FlatAppearance.BorderSize = 0;
            this.btn_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Course.Location = new System.Drawing.Point(49, 101);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(98, 23);
            this.btn_Course.TabIndex = 4;
            this.btn_Course.Text = "Course Form";
            this.btn_Course.UseVisualStyleBackColor = true;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // btn_Exam
            // 
            this.btn_Exam.FlatAppearance.BorderSize = 0;
            this.btn_Exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exam.Location = new System.Drawing.Point(49, 141);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(98, 23);
            this.btn_Exam.TabIndex = 5;
            this.btn_Exam.Text = "Exam Form";
            this.btn_Exam.UseVisualStyleBackColor = true;
            this.btn_Exam.Click += new System.EventHandler(this.btn_Exam_Click);
            // 
            // btn_Mark
            // 
            this.btn_Mark.FlatAppearance.BorderSize = 0;
            this.btn_Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mark.Location = new System.Drawing.Point(49, 181);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(98, 23);
            this.btn_Mark.TabIndex = 6;
            this.btn_Mark.Text = "Mark Form";
            this.btn_Mark.UseVisualStyleBackColor = true;
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
            // 
            // btn_Timetable
            // 
            this.btn_Timetable.FlatAppearance.BorderSize = 0;
            this.btn_Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timetable.ForeColor = System.Drawing.Color.Black;
            this.btn_Timetable.Location = new System.Drawing.Point(49, 221);
            this.btn_Timetable.Name = "btn_Timetable";
            this.btn_Timetable.Size = new System.Drawing.Size(98, 23);
            this.btn_Timetable.TabIndex = 7;
            this.btn_Timetable.Text = "Timetable Form";
            this.btn_Timetable.UseVisualStyleBackColor = true;
            this.btn_Timetable.Click += new System.EventHandler(this.btn_Timetable_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 419);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_lecture
            // 
            this.btn_lecture.FlatAppearance.BorderSize = 0;
            this.btn_lecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lecture.Location = new System.Drawing.Point(63, 20);
            this.btn_lecture.Name = "btn_lecture";
            this.btn_lecture.Size = new System.Drawing.Size(75, 23);
            this.btn_lecture.TabIndex = 2;
            this.btn_lecture.Text = "Lecture";
            this.btn_lecture.UseVisualStyleBackColor = true;
            this.btn_lecture.Click += new System.EventHandler(this.btn_lecture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_Mark;
        private System.Windows.Forms.Button btn_Timetable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Button btn_lecture;
    }
}