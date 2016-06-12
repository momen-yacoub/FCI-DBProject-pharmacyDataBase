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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [Name] ,[Address],[Mobile] FROM [pharmacy].[dbo].[Owner]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Owner");
            dataGridView1.DataSource = ds.Tables["Owner"]; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [Name],[Mobile],[Age],[CustomerNumber] FROM [pharmacy].[dbo].[Customers]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"]; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [OrderID],[ProductID],[ID],[CustomerNumber],[Amount],[Price],[ProductName]FROM [pharmacy].[dbo].[Orders]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            dataGridView1.DataSource = ds.Tables["Orders"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [Name],[ID],[Address],[Mobile],[Salary] FROM [pharmacy].[dbo].[SalesPerson]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "SalesPerson");
            dataGridView1.DataSource = ds.Tables["SalesPerson"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [Name],[Email],[Mobile] FROM [pharmacy].[dbo].[Suppliers]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Suppliers");
            dataGridView1.DataSource = ds.Tables["Suppliers"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [ProductName],[ProductID],[Email],[Amount] FROM [pharmacy].[dbo].[Supply]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Supply");
            dataGridView1.DataSource = ds.Tables["Supply"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");//connection name
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [ProductID],[OrderID],[Name],[Amount],[Tax],[Price],[DateOfExpiry] FROM [pharmacy].[dbo].[Products]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Products");
            dataGridView1.DataSource = ds.Tables["Products"];
        }
    }
}
