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
    public partial class QUANLYNHANVIEN : Form
    {
        public QUANLYNHANVIEN()
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
            cmd.CommandText = "select * from nhanvien";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "insert into nhanvien values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "update nhanvien set manhanvien='" + textBox1.Text + "',tennhanvien='" + textBox2.Text + "',chuc_vu='" + textBox3.Text + "',sdt='" + textBox4.Text + "',mail='" + textBox5.Text + "',gioitinh='" + textBox6.Text + "' where manhanvien='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = min.CreateCommand();
            cmd.CommandText = "delete from nhanvien where manhanvien='" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {this.Close();
            daodienquanly daodienquanly = new daodienquanly();
            daodienquanly.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from nhanvien where manhanvien='" + textBox7.Text + "' ";
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
