using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03032019_Polymorphizm
{
    class Urun
    {
        public string Adi { get; set; }
        public int Adedi { get; set; }
        public decimal Fiyat { get; set; }
        public virtual decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.18m);
        }
        public void UrunGöster()
        {

        }
    }
}
