using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040319Wİn_InterfaceUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Forvet f = new Forvet();
            MessageBox.Show(f.SutCek(98.48f,20));
            MessageBox.Show(SutCek(f,45.44f,17));

        }
        private string SutCek(ISutCekebilable sut,float hiz,float mesafe)
        {
            return sut.SutCek(hiz, mesafe);
        }
    }
}
