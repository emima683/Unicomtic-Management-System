namespace UnicomTicManagementSystem.Views
{
    partial class LectureForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Lecture_DGV = new System.Windows.Forms.DataGridView();
            this.lbl_Lecture = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.combo_Subject = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lecture_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(218, 139);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(355, 139);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(496, 139);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Lecture_DGV
            // 
            this.Lecture_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecture_DGV.Location = new System.Drawing.Point(86, 181);
            this.Lecture_DGV.Name = "Lecture_DGV";
            this.Lecture_DGV.Size = new System.Drawing.Size(602, 240);
            this.Lecture_DGV.TabIndex = 3;
            // 
            // lbl_Lecture
            // 
            this.lbl_Lecture.AutoSize = true;
            this.lbl_Lecture.Location = new System.Drawing.Point(335, 9);
            this.lbl_Lecture.Name = "lbl_Lecture";
            this.lbl_Lecture.Size = new System.Drawing.Size(43, 13);
            this.lbl_Lecture.TabIndex = 4;
            this.lbl_Lecture.Text = "Lecture";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(230, 42);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(230, 75);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 6;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(230, 111);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.lbl_Subject.TabIndex = 7;
            this.lbl_Subject.Text = "Subject";
            // 
            // combo_Subject
            // 
            this.combo_Subject.FormattingEnabled = true;
            this.combo_Subject.Location = new System.Drawing.Point(355, 103);
            this.combo_Subject.Name = "combo_Subject";
            this.combo_Subject.Size = new System.Drawing.Size(228, 21);
            this.combo_Subject.TabIndex = 8;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(355, 68);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(228, 20);
            this.txt_Address.TabIndex = 9;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(355, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(228, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // LectureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.combo_Subject);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Lecture);
            this.Controls.Add(this.Lecture_DGV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Name = "LectureForm";
            this.Text = "LectureForm";
            ((System.ComponentModel.ISupportInitialize)(this.Lecture_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Lecture_DGV;
        private System.Windows.Forms.Label lbl_Lecture;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.ComboBox combo_Subject;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
    }
}