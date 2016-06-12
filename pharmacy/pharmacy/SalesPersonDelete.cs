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
    public partial class SalesPersonDelete : Form
    {
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=MOMEN_SAYEED\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public SalesPersonDelete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete f = new Delete();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            if (ID.Length == 0 || ID.Length > 30)
            {
                errorProvider1.SetError(textBox1, " Please Enter Valid ID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("Delete From SalesPerson Where ID ='" +
                ID.ToString() + "'", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been Deleted ");
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
