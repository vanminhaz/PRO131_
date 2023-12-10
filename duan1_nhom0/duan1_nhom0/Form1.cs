using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace duan1_nhom0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBox2.Text == "quanly" && textBox3.Text == "123")
            {
               
                daodienquanly min = new daodienquanly();
                min.Show();


            }
            else if (textBox2.Text == "nhanviens" && textBox3.Text == "321")
            {
                
                daodienquanly max = new daodienquanly();
                max.khoanotthongke();
                max.khoanotnhanvien();
                max.Show();
            }
            else if (textBox2.Text == "nhanvienk" && textBox3.Text == "321")
            {
               
                daodienquanly max = new daodienquanly();
                max.khoanotthongke();
                max.khoanotbanhang();
                max.khoanotkhachhang();
                max.khoanotnhanvien();
                max.Show();
            }
            else
            {
                MessageBox.Show("user name or password invaled");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QUENMATKHAU min = new QUENMATKHAU();
            min.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
