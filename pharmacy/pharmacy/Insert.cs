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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerInsert f = new OwnerInsert();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderInsert f = new OrderInsert();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomersInsert f = new CustomersInsert();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesPersonInsert f = new SalesPersonInsert();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SuppliersInsert f = new SuppliersInsert();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplyInsert f = new SupplyInsert();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductsInsert f = new ProductsInsert();
            f.Show();
            this.Hide();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
