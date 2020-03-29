using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040319_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            MessageBox.Show(gtr.Cal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            MuzikAletleriCal(kmn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            MessageBox.Show(btr.Cal());
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void MuzikAletleriCal(MuzikAletleri ma)
        {
            MessageBox.Show(ma.Cal());
        }
    }
}
