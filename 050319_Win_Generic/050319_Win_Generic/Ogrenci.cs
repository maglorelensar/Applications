using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050319_Win_Generic
{
    class Ogrenci<T,H,Y> where T:class where H:struct
    {
        /*
         * Dışarıdan bir tip alarak çalışmayı sağlayan yapıdır
         * */
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Y OkulNo { get; set; }
        public H Okulu { get; set; }
        public T TemsiliTip { get; set; }
        public void Ekle(T prm)
        {

        }
    }
}
