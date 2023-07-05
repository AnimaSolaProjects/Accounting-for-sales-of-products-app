using M___C_part;
using System;
using System.Windows.Forms;


namespace View
{
    public partial class RegstrForm : Form
    {
        public RegstrForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegstrForm_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if(controller.Registration(LoginBox.Text, PassBox.Text, AccessCheckBox.Checked))
            {
                this.Hide();
                LogForm form = new LogForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("registration failed");
            }
        }

        private void tologinform_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm form = new LogForm();
            form.Show();
        }

        private void RegstrForm_Leave(object sender, EventArgs e)
        {
            RegstrForm form = new RegstrForm();
            form.Close();
        }
    }
}
