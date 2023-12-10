using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace duan1_nhom0
{
    public partial class BANHANG : Form
    {
        public BANHANG()
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
            cmd.CommandText = "select * from quanlybanhang";
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
        }
        private void BANHANG_Load(object sender, EventArgs e)
        {
            min = new SqlConnection(str);
            min.Open();
            load();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                //
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngayban;
                int giaban=0;
                string makhachhang;
                string tenkhachhang;
                string manhanvien;
                string tennhanvien;
              
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                ngayban= DateTime.Parse(textBox4.Text);
                giaban = int.Parse(textBox5.Text);
                makhachhang = Convert.ToString(textBox6.Text);
                tenkhachhang = Convert.ToString(textBox7.Text);
                manhanvien = Convert.ToString(textBox8.Text);
                tennhanvien = Convert.ToString(textBox9.Text);
                if (soluong > 0 && tensanpham != "" && masanpham != "" && giaban > 0 && makhachhang != "" && tenkhachhang != "" && tennhanvien != "" && manhanvien != "" && ngayban != null )
                {
                    cmd = min.CreateCommand();
                cmd.CommandText = "insert into quanlybanhang values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                cmd.ExecuteNonQuery();
                load();
                MessageBox.Show("da cap nhat thanh cong !");
                    
                        cmd = min.CreateCommand();
                        cmd.CommandText = "update quanlytonkho set soluong-='" + textBox3.Text + "' where masp='" + textBox1.Text + "'and soluong>=0 and soluong > '" + textBox3.Text + "' ";
                        cmd.ExecuteNonQuery();
                    load();
                }

               
               if(soluong<=0)
                {
                    MessageBox.Show("so luong phai lon hon 0");
                }
                if (giaban <= 0)
                {
                    MessageBox.Show("gia ban phai lon hon 0 ");
                }
                if (masanpham == "")
                {
                    MessageBox.Show("ma san pham khong duoc bo trong");
                }
                if (makhachhang == "")
                {
                    MessageBox.Show("ma khach hang khong duoc bo trong");
                }
                if (tenkhachhang == "")
                {
                    MessageBox.Show("ten khach hang khong duoc bo trong");
                }
                if (tensanpham == "")
                {
                    MessageBox.Show("ten san pham khong duoc bo trong");
                }
                 if (manhanvien == "")
                {
                    MessageBox.Show("ma nhan vien khong duoc bo trong");
                }
                 if (tennhanvien == "")
                {
                    MessageBox.Show("ten nhan vien khong duoc bo trong");
                }
                 if (ngayban == null)
                {
                    MessageBox.Show("ngay ban khong duoc bo trong");
                }
               
                
            }
            catch(SqlException ex)
            {
                if (ex.Number==547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
           

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
            textBox7.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }
        public int tonggia = 0;
        public int demslg = 0;
        private void button7_Click(object sender, EventArgs e)
        {
           
            button8.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox10.Text += "\nSO LUONG :'" +demslg + "' \r";
            textBox10.Text += "\nTONG GIA :'" + tonggia + "' \r";
            textBox10.Visible = true;
            label13.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select *from quanlybanhang where maspdb='" + textBox11.Text + "'";
            cmd.ExecuteNonQuery();
            dataAdapter.SelectCommand = cmd;
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox10.Visible = false;
            button8.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            textBox10.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngayban;
                int giaban;
                string makhachhang;
                string tenkhachhang;
                string manhanvien;
                string tennhanvien;
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                DateTime.TryParse(textBox4.Text, out ngayban);
                giaban = int.Parse(textBox5.Text);
                makhachhang = Convert.ToString(textBox6.Text);
                tenkhachhang = Convert.ToString(textBox7.Text);
                manhanvien = Convert.ToString(textBox8.Text);
                tennhanvien = Convert.ToString(textBox9.Text);
                if (soluong > 0 && tensanpham != "" && masanpham != "" && giaban > 0 && makhachhang != "" && tenkhachhang != "" && tennhanvien != "" && manhanvien != "" && ngayban != null)
                {
                    cmd = min.CreateCommand();
                    cmd.CommandText = "update quanlybanhang set maspdb ='" + textBox1.Text + "',tenspdb ='" + textBox2.Text + "',soluong ='" + textBox3.Text + "', ngayban ='" + textBox4.Text + "',gia='" + textBox5.Text + "',makhachhang='" + textBox6.Text + "',tenkhachhang='" + textBox7.Text + "',manhanvien='" + textBox8.Text + "',tennhanvien='" + textBox9.Text + "' where maspdb='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    load();

                }
                if (soluong <= 0 )
                {
                    MessageBox.Show("so luong phai lon hon 0");
                }
               
                if (giaban <= 0)
                {
                    MessageBox.Show("gia ban phai lon hon 0");
                }
               
                if (masanpham == "")
                {
                    MessageBox.Show("ma san pham khong duoc bo trong");
                }
                if (makhachhang == "")
                {
                    MessageBox.Show("ma khach hang khong duoc bo trong");
                }
                if (tenkhachhang == "")
                {
                    MessageBox.Show("ten khach hang khong duoc bo trong");
                }
                if (tensanpham == "")
                {
                    MessageBox.Show("ten san pham khong duoc bo trong");
                }
                if (manhanvien == "")
                {
                    MessageBox.Show("ma nhan vien khong duoc bo trong");
                }
                if (tennhanvien == "")
                {
                    MessageBox.Show("ten nhan vien khong duoc bo trong");
                }
                if (ngayban == null)
                {
                    MessageBox.Show("ngay ban khong duoc bo trong");
                }


            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string masanpham;
                string tensanpham;
                int soluong;
                DateTime ngayban;
                int giaban;
                string makhachhang;
                string tenkhachhang;
                string manhanvien;
                string tennhanvien;
                masanpham = Convert.ToString(textBox1.Text);
                tensanpham = Convert.ToString(textBox2.Text);
                soluong = int.Parse(textBox3.Text);
                DateTime.TryParse(textBox4.Text, out ngayban);
                giaban = int.Parse(textBox5.Text);
                makhachhang = Convert.ToString(textBox6.Text);
                tenkhachhang = Convert.ToString(textBox7.Text);
                manhanvien = Convert.ToString(textBox8.Text);
                tennhanvien = Convert.ToString(textBox9.Text);
                if (soluong > 0 && tensanpham != "" && masanpham != "" && giaban > 0 && makhachhang != "" && tenkhachhang != "" && tennhanvien != "" && manhanvien != "" && ngayban != null)
                {
                    cmd = min.CreateCommand();
                    cmd.CommandText = "delete from quanlybanhang where maspdb='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    load();

                }
                if (soluong <= 0)
                {
                    MessageBox.Show("so luong phai lon hon 0");
                }

                if (giaban <= 0)
                {
                    MessageBox.Show("gia ban phai lon hon 0");
                }

                if (masanpham == "")
                {
                    MessageBox.Show("ma san pham khong duoc bo trong");
                }
                if (makhachhang == "")
                {
                    MessageBox.Show("ma khach hang khong duoc bo trong");
                }
                if (tenkhachhang == "")
                {
                    MessageBox.Show("ten khach hang khong duoc bo trong");
                }
                if (tensanpham == "")
                {
                    MessageBox.Show("ten san pham khong duoc bo trong");
                }
                if (manhanvien == "")
                {
                    MessageBox.Show("ma nhan vien khong duoc bo trong");
                }
                if (tennhanvien == "")
                {
                    MessageBox.Show("ten nhan vien khong duoc bo trong");
                }
                if (ngayban == null)
                {
                    MessageBox.Show("ngay ban khong duoc bo trong");
                }


            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("loi khi nhap sai du lieu");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("loi khi nhap sai du lieu");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string gia = textBox5.Text;
            string sl = textBox3.Text;
            int giaban = int.Parse(gia);
            int slu = int.Parse(sl);

            if (giaban >= 300 || slu > 1)
            {
                cmd = min.CreateCommand();
                cmd.CommandText = "exec sp_nkh '" + textBox6.Text + "','" + textBox7.Text + "',1";
                cmd.ExecuteNonQuery();
                load();
            }
            for (int i = 0; i < 1; i++)
            {
                demslg += 1;
                tonggia += giaban;
                label13.Text=demslg.ToString();
                textBox10.Text += "\nda xuat don !\r" +
                 "\n ma san pham :'" + textBox1.Text + "'\r" +
                 "\n ten san pham :'" + textBox2.Text + "'\r" +
                 "\n so luong :'" + textBox3.Text + "'\r" +
                 "\n ngay ban :'" + textBox4.Text + "'\r" +
                 "\n gia ban :'" + textBox5.Text + "'\r" +
                 "\n ma khach hang :'" + textBox6.Text + "'\r" +
                 "\n ten khach hang :'" + textBox7.Text + "'\r" +
                 "\n ten nhan vien :'" + textBox8.Text + "'\r" +
                 "\n ma nhan vien :'" + textBox9.Text + "'\r" +
                  "\n ===================================\r";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
