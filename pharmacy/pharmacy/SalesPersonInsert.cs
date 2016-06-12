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
    public partial class SalesPersonInsert : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;

        public SalesPersonInsert()
        {
            InitializeComponent();
        }

        private void SalesPersonInsert_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Name, ID , Mobile , Address, Salary;
            Name = textBox1.Text;
            ID = textBox2.Text;
            Mobile = textBox3.Text;
            Address = textBox4.Text;
            Salary = textBox5.Text;
            if (Name.Length == 0 || Name.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid Name ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (ID.Length == 0 || ID.Length > 30)
            {
                errorProvider1.SetError(textBox2, " Please Enter Valid ID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Mobile.Length == 0 || Mobile.Length > 30)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid Mobile ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Address.Length == 0 || Address.Length > 30)
            {
                errorProvider1.SetError(textBox4, " Please Enter Valid Address ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Salary.Length == 0)
            {
                errorProvider1.SetError(textBox5, " Please Enter Valid Salary ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("insert into SalesPerson values ('" +
                Name.ToString() + "','" + ID.ToString() + "','" + Address.ToString() + "','" + Mobile.ToString() + "','" + float.Parse(Salary.ToString()) + "')", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            f.Show();
            this.Close();
        }
    }
}
