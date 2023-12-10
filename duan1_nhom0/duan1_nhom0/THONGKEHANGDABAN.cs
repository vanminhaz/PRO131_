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

namespace duan1_nhom0
{
    public partial class THONGKEHANGDABAN : Form
    {
        public THONGKEHANGDABAN()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection min;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=duan1;Integrated Security=True";
        void load()
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "select * from quanlybanhang";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void THONGKEHANGDABAN_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime truoc;
                DateTime.TryParse(textBox1.Text, out truoc);
                DateTime sau;
                DateTime.TryParse(textBox2.Text, out sau);
                cmd = min.CreateCommand();
                cmd.CommandText = "select * from quanlybanhang where ngayban>='" + textBox1.Text + "' AND ngayban <='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                dataAdapter.SelectCommand = cmd;
                dt.Clear();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (FormatException)
            {
                MessageBox.Show("loi nhap du lieu");
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from quanlybanhang where maspdb='" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            daodienquanly min = new daodienquanly();
            min.Show();
        }
    }
}
