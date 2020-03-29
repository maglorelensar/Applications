using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _050319_Win_Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("Nurseda");
            list.Add(123);
            list.Add(true);
            list.Add("A");
            string isim = (string)list[0];
            List<string> isimler = new List<string>();
            isimler.Add("Barkin");
            List<int> sayilar = new List<int>();
            sayilar.Add(7);
            int sayi = sayilar[0];
            //Ogrenci<Ders,Ders,decimal> o1 = new Ogrenci<Ders,Ders,decimal>();
            //o1.Ekle();
            //Ogrenci <Ders,Ders,bool> o2 = new Ogrenci<int,Ders,bool>();
            //o2.Ekle();
            MetotGeneric mg = new MetotGeneric();
            mg.Add<int>(4);
            mg.Add<string>("Haci");

            

        }
    }
}
