using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSatisUygulamasi
{
    public partial class AnaSayfa : Form
    {

        int toplam = 0;
        int indirimlitutar = 0;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // URL'yi http:// ile başlatmalısınız
            System.Diagnostics.Process.Start("http://www.webtalist.com/");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text + " " + label1.Text);
                toplam = toplam + Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                toplam = toplam - Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
                listBox1.Items.Remove(checkBox1.Text + " " + label1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text + " " + label2.Text);
                toplam = toplam + Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text + " " + label2.Text);
                toplam = toplam - Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text + " " + label3.Text);
                toplam = toplam + Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox3.Text + " " + label3.Text);
                toplam = toplam - Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text + " " + label4.Text);
                toplam = toplam + Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox4.Text + " " + label4.Text);
                toplam = toplam - Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "SVS13")
            {
                indirimlitutar = (toplam * 22) / 100;
                textBox3.Text = (toplam - indirimlitutar).ToString();
                MessageBox.Show($"%22 İndirim Uygulandı Kazancınız {indirimlitutar}", "discount");
            } else
            {
                MessageBox.Show("İndirim Kodu Hatalı" , "UYARI");
                textBox3.Text = "0";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
