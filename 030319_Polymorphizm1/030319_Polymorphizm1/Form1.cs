using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030319_Polymorphizm1
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

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = textBox1.Text;
            ogr.Soyadi = textBox2.Text;
            ogr.TCKN = textBox3.Text;
            ogr.DogumTarihi = dateTimePicker1.Value;
            listBox1.Items.Add(ogr);
            MessageBox.Show(ogr.ToString());
        }
    }
}
