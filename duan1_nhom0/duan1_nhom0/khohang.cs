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
    public partial class khohang : Form
    {
        public khohang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select * from quanlytonkho";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void khohang_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngaynhap;
                int gia;
                string vitri;
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                DateTime.TryParse(textBox4.Text, out ngaynhap);
                gia = int.Parse(textBox5.Text);
                vitri = Convert.ToString(textBox6.Text);
                if (masanpham != "" && tensanpham != "" && soluong <= 0 && ngaynhap != null && gia <= 0 && vitri != "")
                {
                    cmd = min.CreateCommand();
                    cmd.CommandText = "insert into quanlytonkho  values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    cmd.ExecuteNonQuery();
                    load();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
       
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngaynhap;
                int gia;
                string vitri;
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                DateTime.TryParse(textBox4.Text, out ngaynhap);
                gia = int.Parse(textBox5.Text);
                vitri = Convert.ToString(textBox6.Text);
                if (masanpham != "" && tensanpham != "" && soluong <= 0 && ngaynhap != null && gia <= 0 && vitri != "")
                {
                    cmd = min.CreateCommand();
                    cmd.CommandText = "update quanlytonkho  set masp ='" + textBox1.Text + "',tensp ='" + textBox2.Text + "',soluong ='" + textBox3.Text + "', ngaynhap ='" + textBox4.Text + "',gia='" + textBox5.Text + "',vitri='" + textBox6.Text + "'where masp='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    load();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("sua thanh cong");
                }
                else
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i=dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from quanlytonkho where masp='" + textBox7.Text + "'";
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
            daodienquanly daodienquanly = new daodienquanly();
             daodienquanly .Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngaynhap;
                int gia;
                string vitri;
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                DateTime.TryParse(textBox4.Text, out ngaynhap);
                gia = int.Parse(textBox5.Text);
                vitri = Convert.ToString(textBox6.Text);
              
                    cmd = min.CreateCommand();
                    cmd.CommandText = "delete from quanlytonkho where masp ='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    load();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("xoa thanh cong");
                
               
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
    }
}
