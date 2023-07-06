using M___C_part;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logonButton_Click(object sender, EventArgs e)
        {
            string pass = "123456";
            AdminForm adminForm = new AdminForm();
            UserForm userForm = new UserForm();
            if (AdminCheckBox.Checked != true)
            {
                if (LoginBox.Text == pass)
                {
                    adminForm.Show();
                    this.Hide();
                    
                }
            }
            else
            {
                userForm.Show();
                this.Hide();
            }
        }

        
        private void LogForm_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminCheckBox.Checked == true) 
            { 
                LoginBox.Hide();
                label2.Hide();
            }
            else
            {
                LoginBox.Show();
                label2.Show();
            }
        }
    }
}
