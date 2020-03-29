using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _280209_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instance alma..
            Personel p = new Personel();
            Personel p1 = new Personel("Serkan");
            Personel p2 = new Personel(DateTime.Today);
            Personel p3 = new Personel("barkin", "özerol", DateTime.Now, "14523");
            //Object Initializer
            Personel p4 = new Personel
            {
                Adi = "hasan",
                Soyadi = "kara",
                DogumTarihi = DateTime.Now,
                TCKN = "2654376411",
                KayitTarihi = DateTime.Today

            };
        }
    }
}
