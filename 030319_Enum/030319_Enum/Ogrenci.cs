using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030319_Enum
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Alan Alani { get; set; }
    }
    /* String şeklinde enumların içerisine değer yazılmaz
     * Enum  içerisindeki seçenek bir kelimeden fazla olsa bile 
       kelimeler arasında boşluk bırakılmaz.
       Not:Enum'lar kullanıcının seçeceği seçenekler için oluşturulan bir yapı
       değildir.
       *Programcının programını idame ettirmesi için kullandığı bir yapıdır.
       */
    public enum Alan{
        Sayisal,
        Sözel,
        EsitAgirlik,
        Dil
    }
}
