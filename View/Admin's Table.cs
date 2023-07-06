using M___C_part;
using M___C_part.Produckt_s_model;
using M___C_part.User_s_model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace View
{
    public partial class AdminForm : Form
    {
        MyContext MyContext = new MyContext();
        public AdminForm()
        {
            InitializeComponent();
            
        }
        
        private void AdminForm_Load(object sender, EventArgs e)
        {
            MyContext.products.Load();
            MyContext.grains.Load();

            dataGridView1.DataSource = MyContext.products.Local.ToBindingList();
            dataGridView2.DataSource = MyContext.grains.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AdminForm_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Load_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
         
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            MyContext.products.Load();
            MyContext.grains.Load();

            dataGridView1.DataSource = MyContext.products.Local.ToBindingList();
            dataGridView2.DataSource = MyContext.grains.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 0;
            foreach (var item in MyContext.products)
            {
                value += item.Amount;
            }
            amount.Text = value.ToString();
            double value2 = 0;
            foreach (var item in MyContext.grains)
            {
                value2 += item.Amount;
            }
            textBox1.Text = value2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float value = 0;
            foreach (var item in MyContext.products)
            {
                value += item.Price;
            }
            price.Text = value.ToString();
            double value2 = 0;
            foreach (var item in MyContext.grains)
            {
                value2 += item.Price;
            }
            textBox2.Text = value2.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();

            foreach (var product in MyContext.products.Local.ToList())
            {
                if (product.ProductType == null)
                {
                    MyContext.products.Remove(product);
                }
            }
            
            MyContext.SaveChanges();
            dataGridView2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();

            foreach (var grain in MyContext.grains.Local.ToList())
            {
                if (grain.GrainType == null)
                {
                    MyContext.grains.Remove(grain);
                }
            }

            MyContext.SaveChanges();
            dataGridView2.Refresh();
        }
    }
}
