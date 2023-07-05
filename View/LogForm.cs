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
            Controller controller = new Controller();
            if (controller.Login(LoginBox.Text, LoginBox.Text).LevelOfAccess != false)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("wrong data");
                LoginBox.Clear();
                PassBox.Clear();
            }
        }

        private void toRegistrform_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegstrForm form = new RegstrForm();
            form.Show();
        }

        private void LogForm_Leave(object sender, EventArgs e)
        {
            LogForm form = new LogForm();
            form.Close();
        }
    }
}
