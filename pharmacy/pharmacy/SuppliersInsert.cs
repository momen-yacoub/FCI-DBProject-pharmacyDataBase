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
    public partial class SuppliersInsert : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public SuppliersInsert()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name, Email, Mobile;
            Name = textBox1.Text;
            Email = textBox2.Text;
            Mobile = textBox3.Text;
            if (Name.Length == 0 || Name.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid Name ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Email.Length == 0 || Email.Length > 30)
            {
                errorProvider1.SetError(textBox2, " Please Enter Valid Email ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (Mobile.Length == 0 || Mobile.Length > 30)
            {
                errorProvider1.SetError(textBox3, " Please Enter Valid Mobile ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("insert into Suppliers values ('" +
                Name.ToString() + "','" + Email.ToString() + "','" + Mobile.ToString() + "')", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
            } 
        }
    }
}
