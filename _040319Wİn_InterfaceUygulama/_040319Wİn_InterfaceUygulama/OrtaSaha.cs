using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Wİn_InterfaceUygulama
{
    class OrtaSaha : Futbolcu, IOyunKurabilable,ISutCekebilable
    {
        public string CalimAt(float hiz)
        {
            return string.Format("{0} Hızla çalım atıldı",hiz);
        }

        public string OyunKur()
        {
            return "Oyun Kuruldu";
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeyle şut çekildi",hiz,mesafe);
        }
    }
}
