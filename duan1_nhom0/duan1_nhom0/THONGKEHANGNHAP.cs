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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace duan1_nhom0
{
    public partial class THONGKEHANGNHAP : Form
    {
        public THONGKEHANGNHAP()
        {
            InitializeComponent();
        }
        SqlConnection min;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=duan1;Integrated Security=True";
        void load()
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "select * from quanlytonkho";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void THONGKEHANGNHAP_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            daodienquanly daodienquanly = new daodienquanly();
            daodienquanly.Show();
            
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
                cmd.CommandText = "select * from quanlytonkho where '" + textBox1.Text + "'<= ngaynhap AND ngaynhap <='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                dataAdapter.SelectCommand = cmd;
                dt.Clear();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(FormatException) {
                MessageBox.Show("loi nhap du lieu");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from quanlytonkho where masp='" + textBox5.Text + "'";
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
    }
}
