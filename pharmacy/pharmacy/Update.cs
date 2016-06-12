using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pharmacy
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OwnerUpdate f = new OwnerUpdate();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomersUpdate f = new CustomersUpdate();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderUpdate f = new OrderUpdate();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesPersonUpdate f = new SalesPersonUpdate();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SuppliersUpdate f = new SuppliersUpdate();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplyUpdate f = new SupplyUpdate();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductsUpdate f = new ProductsUpdate();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
