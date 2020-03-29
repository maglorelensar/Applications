using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030319_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Alani = Alan.Sayisal;
            Ogrenci o2 = new Ogrenci();
            o2.Alani = Alan.Dil;
            Cinsiyet cs = new Cinsiyet();
            cs.Cinsiyeti = CinsTipi.Erkek;
            o2.Alani = (Alan)1;
            int sys = (int)Alan.Sayisal;
            MessageBox.Show(Enum.GetName(typeof(Alan),o2.Alani));
            string[]alanlar = Enum.GetNames (typeof(Alan));


        }
    }
}
