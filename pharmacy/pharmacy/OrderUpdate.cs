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
    public partial class OrderUpdate : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public OrderUpdate()
        {
            InitializeComponent();
        }

        private void OrderUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ProductID, OrderID, ID, CustomerNumber, Amount, Price, ProductName;
            ProductID = textBox1.Text;
            OrderID = textBox2.Text;
            ID = textBox3.Text;
            CustomerNumber = textBox4.Text;
            Amount = textBox5.Text;
            Price = textBox6.Text;
            ProductName = textBox7.Text;
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
            else if (ID.Length == 0 || ID.Length > 30)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid ID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (CustomerNumber.Length == 0)
            {
                errorProvider1.SetError(textBox4, " Please Enter Valid CustomerID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Amount.Length == 0)
            {
                errorProvider1.SetError(textBox5, " Please Enter Valid Amount ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Price.Length == 0)
            {
                errorProvider1.SetError(textBox6, " Please Enter Valid Price ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (ProductName.Length == 0 || ProductName.Length > 30)
            {
                errorProvider1.SetError(textBox7, " Please Enter Valid ProductName ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("Update Orders Set Amount = '" +
                Int32.Parse(Amount.ToString()) + "',Price = '" + float.Parse(Price.ToString()) + "',ProductName = '" + ProductName.ToString() + " Where OrderID = '" + OrderID + "'", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been Updated ");
                con.Close();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update f = new Update();
            f.Show();
            this.Close();

        }
    }
}
