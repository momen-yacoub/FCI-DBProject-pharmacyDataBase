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
    public partial class CustomersInsert : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public CustomersInsert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name, Mobile, Age, CustomerNumber;
            Name = textBox1.Text;
            Mobile = textBox2.Text;
            Age = textBox3.Text;
            CustomerNumber = textBox4.Text;
            if (Name.Length == 0 || Name.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid Name ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Mobile.Length == 0 || Mobile.Length > 30)
            {
                errorProvider1.SetError(textBox2, " Please Enter Valid Mobile ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Age.Length == 0)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid Age ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (CustomerNumber.Length == 0)
            {
                errorProvider1.SetError(textBox4, " Please Enter Valid CustomerNumber ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("insert into Customers values ('" +
                Name.ToString() + "','" + Mobile.ToString() + "','" + Int32.Parse(Age.ToString()) + "','" + Int32.Parse(CustomerNumber.ToString()) + "')", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
            } 
        }
    }
}
