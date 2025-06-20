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
            this.lbl_ExamName = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txtE_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Exam_DGV = new System.Windows.Forms.DataGridView();
            this.lbl_EForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exam_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ExamName
            // 
            this.lbl_ExamName.AutoSize = true;
            this.lbl_ExamName.Location = new System.Drawing.Point(252, 50);
            this.lbl_ExamName.Name = "lbl_ExamName";
            this.lbl_ExamName.Size = new System.Drawing.Size(64, 13);
            this.lbl_ExamName.TabIndex = 0;
            this.lbl_ExamName.Text = "Exam Name";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(252, 91);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(48, 13);
            this.lbl_Subject.TabIndex = 1;
            this.lbl_Subject.Text = "Subjects";
            // 
            // txtE_Name
            // 
            this.txtE_Name.Location = new System.Drawing.Point(401, 43);
            this.txtE_Name.Name = "txtE_Name";
            this.txtE_Name.Size = new System.Drawing.Size(185, 20);
            this.txtE_Name.TabIndex = 3;
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Location = new System.Drawing.Point(401, 83);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(185, 21);
            this.comboBox_Subject.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(269, 136);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(382, 136);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(485, 136);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Exam_DGV
            // 
            this.Exam_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exam_DGV.Location = new System.Drawing.Point(115, 175);
            this.Exam_DGV.Name = "Exam_DGV";
            this.Exam_DGV.Size = new System.Drawing.Size(562, 263);
            this.Exam_DGV.TabIndex = 8;
            this.Exam_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Exam_DGV_CellContentClick);
            // 
            // lbl_EForm
            // 
            this.lbl_EForm.AutoSize = true;
            this.lbl_EForm.Location = new System.Drawing.Point(379, 9);
            this.lbl_EForm.Name = "lbl_EForm";
            this.lbl_EForm.Size = new System.Drawing.Size(33, 13);
            this.lbl_EForm.TabIndex = 9;
            this.lbl_EForm.Text = "Exam";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_EForm);
            this.Controls.Add(this.Exam_DGV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comboBox_Subject);
            this.Controls.Add(this.txtE_Name);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_ExamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Exam_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExamName;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox txtE_Name;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Exam_DGV;
        private System.Windows.Forms.Label lbl_EForm;
    }
}