using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319_Abstract
{
    abstract class MuzikAletleri
    {
        /*Abstract(Soyut):
         * -Abstract metotlar sadece miras verilmek için tasarlanan sınıflardır
         * -Abstraclar sınıfa özel değildir,bir property ,bir metot veya herhangi bir
         * eleman abstract olabilir.
         * -Abstract metotların gövdesi olmaz.
         * -Abstract metotlar abstract olmayan bir sınıfta bulunamaz.
         * -Abstract sınıflar içerisindeki  abstract olan property veya metotların 
         * gövdesi olmadığı için bu metotlara erişilmesin diye abstract sınıflardan
         * instance üretilemez.
         * -Sınıf abstract olsada içerisinde abstract olmayan metot veya property 
         * bulunabilir.
         * -Ancak abstract bir metot veya bir property abstrack olmayan bir sınıfta 
         * bulunamaz.
         * -Miras verecegimiz sınıftan instance üretmek istemeyiz.
         * */
        public abstract string Cal();
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTipi CalmaTipi { get; set; }

    }
}
