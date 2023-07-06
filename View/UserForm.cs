using M___C_part.User_s_model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace View
{
    public partial class UserForm : Form
    {
        MyContext myContext = new MyContext();
        public UserForm()
        {
            InitializeComponent();
        }
        private void UserForm_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            myContext.products.Load();
            myContext.grains.Load();

            Products.DataSource = myContext.products.Local.ToBindingList();
            Grain.DataSource = myContext.grains.Local.ToBindingList();
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 0;
            foreach (var item in myContext.products)
            {
                value += item.Amount;
            }
            amount.Text = value.ToString();
            double value2 = 0;
            foreach(var item in myContext.grains)
            {
                value2 += item.Amount;
            }
            textBox1.Text = value2.ToString();
        }

        private void Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value = 0;
            foreach (var item in myContext.products)
            {
                value += item.Price;
            }
            price.Text = value.ToString();
            float value2 = 0;
            foreach (var item in myContext.grains)
            {
                value2 += item.Price;
            }
            textBox2.Text = value2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
