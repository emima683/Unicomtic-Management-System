namespace UnicomTicManagementSystem.Views
{
    partial class LoginForm
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_U_Name = new System.Windows.Forms.Label();
            this.lbl_P_Word = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.combo_Role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(344, 27);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(33, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_U_Name
            // 
            this.lbl_U_Name.AutoSize = true;
            this.lbl_U_Name.Location = new System.Drawing.Point(214, 92);
            this.lbl_U_Name.Name = "lbl_U_Name";
            this.lbl_U_Name.Size = new System.Drawing.Size(57, 13);
            this.lbl_U_Name.TabIndex = 1;
            this.lbl_U_Name.Text = "UserName";
            // 
            // lbl_P_Word
            // 
            this.lbl_P_Word.AutoSize = true;
            this.lbl_P_Word.Location = new System.Drawing.Point(214, 130);
            this.lbl_P_Word.Name = "lbl_P_Word";
            this.lbl_P_Word.Size = new System.Drawing.Size(53, 13);
            this.lbl_P_Word.TabIndex = 1;
            this.lbl_P_Word.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(324, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(324, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(420, 194);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(89, 30);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(214, 162);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(29, 13);
            this.lbl_Role.TabIndex = 4;
            this.lbl_Role.Text = "Role";
            // 
            // combo_Role
            // 
            this.combo_Role.FormattingEnabled = true;
            this.combo_Role.Location = new System.Drawing.Point(324, 154);
            this.combo_Role.Name = "combo_Role";
            this.combo_Role.Size = new System.Drawing.Size(185, 21);
            this.combo_Role.TabIndex = 5;
            this.combo_Role.SelectedIndexChanged += new System.EventHandler(this.combo_Role_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_Role);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbl_P_Word);
            this.Controls.Add(this.lbl_U_Name);
            this.Controls.Add(this.lbl_Login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_U_Name;
        private System.Windows.Forms.Label lbl_P_Word;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox combo_Role;
    }
}