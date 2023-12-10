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
    public partial class QUENMATKHAU : Form
    {
        public QUENMATKHAU()
        {
            InitializeComponent();
        }

        private void QUENMATKHAU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox1.Text == "170204")
            {
                MessageBox.Show("NHẬP MÃ THÀNH CÔNG");
                label2.Text = "pass : 123";
            }
            else if (checkBox2.Checked && textBox1.Text == "170204")
            {
                MessageBox.Show("NHẬP MÃ THÀNH CÔNG");
                label2.Text = "pass : 321";
            }
            else
            {
                MessageBox.Show("NHẬP SAI TÁC VỤ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)

        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
           
        }
    }
}
