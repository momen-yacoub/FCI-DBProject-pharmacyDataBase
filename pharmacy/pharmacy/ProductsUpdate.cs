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
    public partial class ProductsUpdate : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public ProductsUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update f = new Update();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ProductID, OrderID, Name, Amount, Tax, Price, DateOfExpire;
            ProductID = textBox1.Text;
            OrderID = textBox2.Text;
            Name = textBox3.Text;
            Amount = textBox4.Text;
            Tax = textBox5.Text;
            Price = textBox6.Text;
            DateOfExpire = textBox7.Text;
            if (ProductID.Length == 0 || ProductID.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid ProductID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (OrderID.Length == 0 || OrderID.Length > 30)
            {
                errorProvider1.SetError(textBox2, " Please Enter Valid OrderID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Name.Length == 0 || Name.Length > 30)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid Name ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Amount.Length == 0)
            {
                errorProvider1.SetError(textBox4, " Please Enter Valid Amount ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Tax.Length == 0)
            {
                errorProvider1.SetError(textBox5, " Please Enter Valid Tax ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Price.Length == 0)
            {
                errorProvider1.SetError(textBox6, " Please Enter Valid Price ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (DateOfExpire.Length == 0 || DateOfExpire.Length > 30)
            {
                errorProvider1.SetError(textBox7, " Please Enter Valid DateOfExpire ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("Update Products set Name ='" 
                + Name.ToString() + "',Amount = '" + Int32.Parse(Amount.ToString())
                + "',Tax = '" + Int32.Parse(Tax.ToString()) + "',Price = '" + float.Parse(Price.ToString()) + "',DateOfExpire = '" + DateOfExpire + "' Where ProductID = '" + ProductID + "'", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been Updated");
                con.Close();
            } 
        }
    }
}
