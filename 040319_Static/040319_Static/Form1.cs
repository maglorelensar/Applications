using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040319_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Adi = "Ali";
            Ogrenci o2 = new Ogrenci();
            o2.Adi = "Veli";

            MessageBox.Show(o1.Adi);
            MessageBox.Show(o2.Adi);

        }
    }
}
