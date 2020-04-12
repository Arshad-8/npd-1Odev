using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarhOrtalama_B171200555_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int o, k, v, f;
            double sonuc;
            k = Convert.ToInt32(textBox1.Text); // kısa sınav değişkeni 
            o = Convert.ToInt32(textBox2.Text); // Ödev değişkeni   
            v = Convert.ToInt32(textBox3.Text); // Vize değişkeni
            f = Convert.ToInt32(textBox4.Text); // Final değişkeni
            sonuc = (o * 0.10) + (k * 0.10) + (v * 0.30) + (f * 0.50); // Her notun katkısı 
            label8.Text = Convert.ToString(sonuc); // ortalama
            
            // HARD HESABLAMA :

            if (sonuc >= 0 && sonuc < 40)
            {
                label9.Text = "FF";
                label9.ForeColor = Color.Red;
            }

            if (sonuc >= 40 && sonuc < 50)
            {
                label9.Text = "DD";
                label9.ForeColor = Color.Gold;
            }


            if (sonuc >= 50 && sonuc < 60)
            {
                label9.Text = "CC";
                label9.ForeColor = Color.Gold;
            }
            if (sonuc >= 60 && sonuc < 70)
            {
                label9.Text = "CB";
                label9.ForeColor = Color.Orange;
            }
            if (sonuc >= 70 && sonuc < 80)
            {
                label9.Text = "BB";
                label9.ForeColor = Color.OrangeRed;
            }
            if (sonuc >= 80 && sonuc < 90)
            {
                label9.Text = "BA";
                label9.ForeColor = Color.OrangeRed;
            }
            if (sonuc >= 90 && sonuc <= 100)
            {
                label9.Text = "AA";
                label9.ForeColor = Color.Green;
            }
            // Girdiler yanlış ise !
            if (sonuc > 100)
            {
                label8.Text = "Yanlış not veya notlar girdiniz.";
                label9.Text = "Yanlış not veya notlar girdiniz.";
            }
        }
    }
}
