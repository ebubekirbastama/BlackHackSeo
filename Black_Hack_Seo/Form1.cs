using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black_Hack_Seo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList siteler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            siteler.Add("http://www.ebubekirbastama.com/2016/12/c-yazlm-egitim-istek-soru-cevap.html");
            siteler.Add("http://www.ebubekirbastama.com/2016/12/ogretmenlerimiz-icin-kutuphane.html");
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (siteler.Count!=sayac)
            {                
                webBrowser1.Navigate(siteler[sayac].ToString());
                sayac++;
            }
        }
        Random rnd = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            int kod = rnd.Next(65, 91);
            char karakter = Convert.ToChar(kod+kod+9);
            webBrowser2.Navigate(textBox1.Text + "" +"http://www."+ ""+ karakter+"xhamster"+".com");
            listBox1.Items.Add(textBox1.Text + "" + "http://www." + "" + karakter + "xhamster" + ".com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
