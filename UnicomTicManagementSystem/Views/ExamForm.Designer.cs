namespace UnicomTicManagementSystem.Views
{
    partial class ExamForm
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
            this.lblE_Name = new System.Windows.Forms.Label();
            this.lbl_Exam = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Exam_DGV = new System.Windows.Forms.DataGridView();
            this.combo_Subject = new System.Windows.Forms.ComboBox();
            this.txtE_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exam_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblE_Name
            // 
            this.lblE_Name.AutoSize = true;
            this.lblE_Name.Location = new System.Drawing.Point(235, 39);
            this.lblE_Name.Name = "lblE_Name";
            this.lblE_Name.Size = new System.Drawing.Size(64, 13);
            this.lblE_Name.TabIndex = 0;
            this.lblE_Name.Text = "Exam Name";
            // 
            // lbl_Exam
            // 
            this.lbl_Exam.AutoSize = true;
            this.lbl_Exam.Location = new System.Drawing.Point(335, 9);
            this.lbl_Exam.Name = "lbl_Exam";
            this.lbl_Exam.Size = new System.Drawing.Size(33, 13);
            this.lbl_Exam.TabIndex = 1;
            this.lbl_Exam.Text = "Exam";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(235, 79);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.lbl_Subject.TabIndex = 2;
            this.lbl_Subject.Text = "Subject";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(238, 120);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(338, 120);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(438, 120);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Exam_DGV
            // 
            this.Exam_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exam_DGV.Location = new System.Drawing.Point(141, 165);
            this.Exam_DGV.Name = "Exam_DGV";
            this.Exam_DGV.Size = new System.Drawing.Size(468, 256);
            this.Exam_DGV.TabIndex = 6;
            this.Exam_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Exam_DGV_CellContentClick);
            // 
            // combo_Subject
            // 
            this.combo_Subject.FormattingEnabled = true;
            this.combo_Subject.Location = new System.Drawing.Point(327, 79);
            this.combo_Subject.Name = "combo_Subject";
            this.combo_Subject.Size = new System.Drawing.Size(195, 21);
            this.combo_Subject.TabIndex = 7;
            // 
            // txtE_Name
            // 
            this.txtE_Name.Location = new System.Drawing.Point(327, 40);
            this.txtE_Name.Name = "txtE_Name";
            this.txtE_Name.Size = new System.Drawing.Size(195, 20);
            this.txtE_Name.TabIndex = 8;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtE_Name);
            this.Controls.Add(this.combo_Subject);
            this.Controls.Add(this.Exam_DGV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Exam);
            this.Controls.Add(this.lblE_Name);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exam_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblE_Name;
        private System.Windows.Forms.Label lbl_Exam;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Exam_DGV;
        private System.Windows.Forms.ComboBox combo_Subject;
        private System.Windows.Forms.TextBox txtE_Name;
    }
}