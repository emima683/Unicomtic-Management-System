namespace UnicomTicManagementSystem.DashBoardForm
{
    partial class StudenDashBoardForm
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
            this.btn_mark = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_timetable);
            this.panel2.Controls.Add(this.btn_mark);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 413);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 413);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_mark
            // 
            this.btn_mark.FlatAppearance.BorderSize = 0;
            this.btn_mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mark.Location = new System.Drawing.Point(56, 43);
            this.btn_mark.Name = "btn_mark";
            this.btn_mark.Size = new System.Drawing.Size(96, 33);
            this.btn_mark.TabIndex = 0;
            this.btn_mark.Text = "View Mark";
            this.btn_mark.UseVisualStyleBackColor = true;
            this.btn_mark.Click += new System.EventHandler(this.btn_mark_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.FlatAppearance.BorderSize = 0;
            this.btn_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timetable.Location = new System.Drawing.Point(29, 109);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(143, 23);
            this.btn_timetable.TabIndex = 1;
            this.btn_timetable.Text = "View Timetable";
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // StudenDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudenDashBoardForm";
            this.Text = "StudentMarksDashBoardForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button btn_mark;
        private System.Windows.Forms.Panel panel3;
    }
}