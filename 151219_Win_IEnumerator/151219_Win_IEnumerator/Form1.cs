using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _151219_Win_IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Takım tkm = new Takım();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = textBox1.Text;
            o.DogumTarihi = DateTime.Now;
            o.FormaNo=7;
            o.Mevkisi = "Forvet";
            o.Soyadi = "Ozerol";
            o.Uyrugu = "Çin";
            tkm.Oyuncular.Add(o);
            listBox1.Items.Add(o.Adi);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "Urfa Spor";
            tkm.KurulusYili = Convert.ToDateTime("25.09.2019");
            tkm.StadIsmi = "Alianz Arena";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Oyuncu o in tkm.Oyuncular)
            {
                listBox2.Items.Add(o.Adi);
            }
        }
    }
}
