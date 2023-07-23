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
namespace data1
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\PwintPhooWai\database\data1\data1\StudDB.mdf;Integrated Security=True");
         con.Open();

         SqlCommand cmd = new SqlCommand("insert into Student values('" + text1.Text + "', '" + text2.Text + "', '" + text3.Text + "', '" + text4.Text + "', '" + text5.Text + "')", con);
        

        cmd.ExecuteNonQuery();

         con.Close();
         MessageBox.Show("inserted datas");

         
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
