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
    public partial class SupplyInsert : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public SupplyInsert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ProductName, ProductID, Email, Amount;
            ProductName = textBox1.Text;
            ProductID = textBox2.Text;
            Email = textBox3.Text;
            Amount = textBox4.Text;
            if (ProductName.Length == 0 || ProductName.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid ProductName ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (ProductID.Length == 0 || ProductID.Length > 30)
            {
                errorProvider1.SetError(textBox2, " Please Enter Valid ProductID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Email.Length == 0 || Email.Length > 30)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid Email ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Amount.Length == 0)
            {
                errorProvider1.SetError(textBox4, " Please Enter Valid Amount ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("insert into Supply values ('" +
                ProductName.ToString() + "','" + ProductID.ToString() + "','" + Email.ToString() +  "','" + Int32.Parse(Amount.ToString()) +"')", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
            } 
        }
    }
}
