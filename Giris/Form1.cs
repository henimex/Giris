using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "f.oygur" && textBox2.Text == "2705")
            {
                label4.Text = "Giriş Başarılı";
                MessageBox.Show("Giriş Başarılı");
                System.Threading.Thread.Sleep(2000);
                Form2 prg1 = new Form2();
                prg1.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "Kullanıcı Bilgileri Hatalı\nLütfen Tekrar Deneyiniz";
            }

 //           Form2 swform = new Form2();
   //         swform.Show();
     //       this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
