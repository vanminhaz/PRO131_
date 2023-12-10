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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }
        SqlConnection min;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=duan1;Integrated Security=True";
        void load()
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "select * from khach_hang";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "insert into khach_hang values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmd.ExecuteNonQuery();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "update khach_hang set makhachhang='" + textBox1.Text + "',tenkhachhang'" + textBox2.Text + "',diemtichluy'" + textBox3.Text + "' ";
            cmd.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "delete from khach_hang where makhachhang='" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from khach_hang where makhachhang='" + textBox7.Text + "' ";
            cmd.ExecuteNonQuery();
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
           daodienquanly daodienquanly = new daodienquanly();
            daodienquanly.Show();
        }
    }
}
