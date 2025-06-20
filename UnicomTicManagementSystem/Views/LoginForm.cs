using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void combo_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string[,] credential = new string[,]
            {
                {"Admin", "admin", "Admin@123" },
                {"Lecture", "lecture", "Lecture@123" },
                {"Staff", "staff", "Staff@123" },
                {"Student", "student", "Student@123" }


            };
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = combo_Role.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter all.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isValid = false;
            for(int i = 0; i < credential.GetLength(0); i++)
            {
                if (credential[i, 0] == role &&
                    credential[i, 1] == username &&
                    credential[i, 2] == password)
                {

                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                MessageBox.Show($"Login successfull as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"Invalid credentials. Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            combo_Role.Items.Add("Admin");
            combo_Role.Items.Add("Lecture");
            combo_Role.Items.Add("Staff");
            combo_Role.Items.Add("Student");
            combo_Role.SelectedIndex = 0;
        }
    }
}

