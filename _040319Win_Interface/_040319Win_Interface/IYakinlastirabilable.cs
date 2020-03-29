using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Win_Interface
{
    interface IYakinlastirabilable
    {
        /*
        *İnterface içerisinde property,metot indexleyici ve event haricinde
         bir şey bulunmaz.
        *Abstract'ta oldugu gibi gövdesi olmaz.
        *Abstractan 1.Farkı:Gövdesi olan bir metot veya property yazamayız.
        * 2.Farkı:Interface içerisindeki elemanların access modifiersleri bulunmaz
        * ve varsayılan access modifiersleri publictir.
        * İnstance üretilmez.
        * Önce miras alır sonra istedigi kadar interface alir.
        
         */
        string Yakinlastir();
    }
}
