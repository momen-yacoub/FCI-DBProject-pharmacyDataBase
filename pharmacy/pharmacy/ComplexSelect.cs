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
    public partial class ComplexSelect : Form
    {
        public ComplexSelect()
        {
            InitializeComponent();
        }

        private void ComplexSelect_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name , Mobile , orderID , ProductName from Customers inner join Orders on Customers.CustomerNumber = Orders.CustomerNumber", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table");
            dataGridView1.DataSource = ds.Tables["Table"]; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("select ProductName , Price from Products left outer join Supply on Products.ProductID = Supply.ProductID", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table2");
            dataGridView1.DataSource = ds.Tables["Table2"];   
        }
    }
}
