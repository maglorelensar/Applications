using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010319_Inheritance2
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

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sy = new SebzeYemekleri();
            YemkeSunumSekliGöster(sy);
            //MessageBox.Show(sy.Sunumsekli());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            YemkeSunumSekliGöster(ey);
            //MessageBox.Show(ey.Sunumsekli());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSıcaklar a= new AraSıcaklar();
            YemkeSunumSekliGöster(a);
            //MessageBox.Show(a.Sunumsekli());
        }
        void YemkeSunumSekliGöster(Yemek ymk)
        {
            MessageBox.Show(ymk.Sunumsekli());
        }
    }
}
