using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319_Static
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanmimliOgrenciSayisi++;
        }
        public  string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
        public static int TanmimliOgrenciSayisi { get; set; }
        //Sınıftan instance almadan sınıfın sonuna nokta koyarak static elemana 
        //ulaşmamızı sağlar.
        public static void Ekle()
        {
            /*Static metotlar içreisinden static olmayan değişkenlere ulaşılamaz
            */
            //Static metotlar içerisinde sadece static elemanlara ulaşılabilir.
            //Geekesiz yere ram kullanılması önlenir.Performans artar maliyet düşer .
            //İçerisindeki bütün değerler static olacaksa sınıf static tanımlanır
        }
    }
}
