namespace UnicomTicManagementSystem.Views
{
    partial class RoomForm
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
            this.lbl_Room = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Room_DGV = new System.Windows.Forms.DataGridView();
            this.combo_RoomType = new System.Windows.Forms.ComboBox();
            this.txt_RoomName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Room_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Room.Location = new System.Drawing.Point(343, 30);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(54, 18);
            this.lbl_Room.TabIndex = 0;
            this.lbl_Room.Text = "Room";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(224, 63);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(66, 13);
            this.lbl_RoomName.TabIndex = 1;
            this.lbl_RoomName.Text = "Room Name";
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.Location = new System.Drawing.Point(224, 107);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(62, 13);
            this.lbl_RoomType.TabIndex = 2;
            this.lbl_RoomType.Text = "Room Type";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(250, 144);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(357, 144);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(466, 144);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Room_DGV
            // 
            this.Room_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_DGV.Location = new System.Drawing.Point(106, 184);
            this.Room_DGV.Name = "Room_DGV";
            this.Room_DGV.Size = new System.Drawing.Size(577, 243);
            this.Room_DGV.TabIndex = 6;
            // 
            // combo_RoomType
            // 
            this.combo_RoomType.FormattingEnabled = true;
            this.combo_RoomType.Location = new System.Drawing.Point(357, 99);
            this.combo_RoomType.Name = "combo_RoomType";
            this.combo_RoomType.Size = new System.Drawing.Size(184, 21);
            this.combo_RoomType.TabIndex = 7;
            // 
            // txt_RoomName
            // 
            this.txt_RoomName.Location = new System.Drawing.Point(357, 60);
            this.txt_RoomName.Name = "txt_RoomName";
            this.txt_RoomName.Size = new System.Drawing.Size(184, 20);
            this.txt_RoomName.TabIndex = 8;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_RoomName);
            this.Controls.Add(this.combo_RoomType);
            this.Controls.Add(this.Room_DGV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_RoomType);
            this.Controls.Add(this.lbl_RoomName);
            this.Controls.Add(this.lbl_Room);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.Room_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.Label lbl_RoomType;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Room_DGV;
        private System.Windows.Forms.ComboBox combo_RoomType;
        private System.Windows.Forms.TextBox txt_RoomName;
    }
}