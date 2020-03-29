using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03032019_Polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet s = new Sepet();
            Ekmek ekm = new Ekmek();
            ekm.Gramaj = 100;
            ekm.Fiyat = 0.75m;
            s.UrunEkle(ekm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TekstilUrunu t = new TekstilUrunu();
            t.Adedi = 5;
            t.Fiyat = 10;
            t.KumasRengi="Kırmızı";
            Sepet s = new Sepet();
            s.UrunEkle(t);          



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elektronik ele = new Elektronik();
            Sepet s = new Sepet();
            ele.Fiyat = 150;
            s.UrunEkle(ele);
            MessageBox.Show();

        }
        

        
    }
}
