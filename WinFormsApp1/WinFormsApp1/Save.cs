using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=23.229.99.142;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Student values('" + txtRno.Text + "', '" + txtName.Text + "', '" + txtYear.Text + "')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("saved this");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("cannot" + ex);
            }
            {

            }
        }
    }
}
