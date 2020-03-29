using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280219_Encapsulation
{
    class Urun
    {  //Bir sınıf içerisinde tanımlanan değişkenlere field(alan) denir.
        //field
        private string _Adi;
        //Property
        public string Adi
        {
            get
            {
                if (_Adi == "Admin")
                {
                    return "Hoşgeldin Patron";
                }else
                {
                    return "Admin değilsiniz oturumunuz açılamadı";
                }
                
            }
            set
            {
                if (value == "Admin")
                {
                    _Adi = value;
                }
                
            }
        }
        public void AdiYaz(string deger)
        {
            if (deger =="Nurseda")
            {
                Adi = deger;
            }
        }
        public string AdiOku()
        {
            if (true)
            {

            }
            return Adi;
        }
        public string Soyadi;
    }
}
