using M___C_part;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.GrainAdd(Type.Text, double.Parse(amountbox.Text), float.Parse(PriceBox.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
