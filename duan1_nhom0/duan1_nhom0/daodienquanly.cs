using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duan1_nhom0
{
    public partial class daodienquanly : Form
    {
        public daodienquanly()
        {
            InitializeComponent();
        }

        private void sdafdfdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tHỐNGKÊToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tHỐNGKÊToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void qUẢNLÝToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cdasfadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            khohang min=new khohang();
            min.Show();
            
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tƯETRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BANHANG min= new BANHANG();
            min.Show();
           
        }

        private void trangQuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            QUANLYNHANVIEN min=new QUANLYNHANVIEN();
            min.Show(); 
           
        }

        private void tHỐNGKÊSẢNPHẨMĐÃBÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            THONGKEHANGDABAN min=new THONGKEHANGDABAN();
            min.Show();
            
        }

        private void tHỐNGKÊSẢNPHẨMNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            THONGKEHANGNHAP min=new THONGKEHANGNHAP();
            min.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            
           
        }

        private void trangQuanLyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();   
            KHACHHANG min=new KHACHHANG();
            min.Show();
        }

        private void lIÊNHỆToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void khoanotthongke()
        {
            tHỐNGKÊToolStripMenuItem.Visible = false;
        }
        public void khoanotbanhang() { 
        qUẢNLÝToolStripMenuItem.Visible = false;    
        
        }
        public void khoanotkhachhang()
        {
            qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Visible = false;

        }
        public void khoanotnhanvien()
        {
           qUẢNLÝNHÂNVIÊNToolStripMenuItem.Visible = false;

        }
        private void daodienquanly_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
