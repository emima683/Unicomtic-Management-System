namespace UnicomTicManagementSystem.Views
{
    partial class MarkForm
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
            this.lbl_Student = new System.Windows.Forms.Label();
            this.lbl_Exam = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Mark = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Mark_DGV = new System.Windows.Forms.DataGridView();
            this.combo_Exam = new System.Windows.Forms.ComboBox();
            this.combo_Student = new System.Windows.Forms.ComboBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Student
            // 
            this.lbl_Student.AutoSize = true;
            this.lbl_Student.Location = new System.Drawing.Point(231, 45);
            this.lbl_Student.Name = "lbl_Student";
            this.lbl_Student.Size = new System.Drawing.Size(44, 13);
            this.lbl_Student.TabIndex = 0;
            this.lbl_Student.Text = "Student";
            // 
            // lbl_Exam
            // 
            this.lbl_Exam.AutoSize = true;
            this.lbl_Exam.Location = new System.Drawing.Point(231, 90);
            this.lbl_Exam.Name = "lbl_Exam";
            this.lbl_Exam.Size = new System.Drawing.Size(33, 13);
            this.lbl_Exam.TabIndex = 1;
            this.lbl_Exam.Text = "Exam";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(231, 125);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(35, 13);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "Score";
            // 
            // lbl_Mark
            // 
            this.lbl_Mark.AutoSize = true;
            this.lbl_Mark.Location = new System.Drawing.Point(327, 20);
            this.lbl_Mark.Name = "lbl_Mark";
            this.lbl_Mark.Size = new System.Drawing.Size(31, 13);
            this.lbl_Mark.TabIndex = 3;
            this.lbl_Mark.Text = "Mark";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(229, 155);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(349, 155);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(489, 155);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Mark_DGV
            // 
            this.Mark_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mark_DGV.Location = new System.Drawing.Point(74, 200);
            this.Mark_DGV.Name = "Mark_DGV";
            this.Mark_DGV.Size = new System.Drawing.Size(523, 210);
            this.Mark_DGV.TabIndex = 7;
            this.Mark_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mark_DGV_CellContentClick);
            // 
            // combo_Exam
            // 
            this.combo_Exam.FormattingEnabled = true;
            this.combo_Exam.Location = new System.Drawing.Point(358, 82);
            this.combo_Exam.Name = "combo_Exam";
            this.combo_Exam.Size = new System.Drawing.Size(186, 21);
            this.combo_Exam.TabIndex = 8;
            // 
            // combo_Student
            // 
            this.combo_Student.FormattingEnabled = true;
            this.combo_Student.Location = new System.Drawing.Point(358, 42);
            this.combo_Student.Name = "combo_Student";
            this.combo_Student.Size = new System.Drawing.Size(186, 21);
            this.combo_Student.TabIndex = 9;
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(358, 122);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(186, 20);
            this.txt_Score.TabIndex = 10;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.combo_Student);
            this.Controls.Add(this.combo_Exam);
            this.Controls.Add(this.Mark_DGV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Mark);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Exam);
            this.Controls.Add(this.lbl_Student);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mark_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student;
        private System.Windows.Forms.Label lbl_Exam;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Mark;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Mark_DGV;
        private System.Windows.Forms.ComboBox combo_Exam;
        private System.Windows.Forms.ComboBox combo_Student;
        private System.Windows.Forms.TextBox txt_Score;
    }
}