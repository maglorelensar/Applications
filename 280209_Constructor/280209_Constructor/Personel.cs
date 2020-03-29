using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280209_Constructor
{
    class Personel
    {
        public Personel()
        {
            KayitTarihi = DateTime.Now;
        }
        public Personel(string ad)
        {
            Adi = ad;
        }
        public Personel(string ad,string soyad,DateTime dogumtarihi,string tckn)
        {

        }
        public Personel(DateTime dt)
        {

        }
        internal string Adi;
        internal string Soyadi;
        public DateTime DogumTarihi;
        public string TCKN;
        public DateTime KayitTarihi = DateTime.Now;

        /*Constructor yapıcı metod
         * 
         * 
         * */
    }
}
