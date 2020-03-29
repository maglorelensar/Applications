using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03032019_Polymorphizm
{
    class Sepet
    {
        public decimal ToplamFiyat { get; set; }
        public void UrunEkle(Urun urn)
        {
            ToplamFiyat += urn.KdvliFiyatHesapla();
        }
    }
}
