using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030319_Polymorphizm1
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Adi, Soyadi, TCKN,
                DogumTarihi);
        }
    }
}
