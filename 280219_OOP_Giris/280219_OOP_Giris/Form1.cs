using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _280219_OOP_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
            Personel[] personeller = new Personel[100];
            int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.adi = textBox1.Text;
            p.soyadi = textBox2.Text;
            p.dogumtarihi = dateTimePicker1.Value;
            p.TCKN = textBox3.Text;
            p.PersonelEkle(p);
            personeller[sayac] = p;
            sayac++;
            MessageBox.Show(p.adi,p.soyadi);
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
