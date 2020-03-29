using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Wİn_InterfaceUygulama
{
    class Forvet : Futbolcu, ISutCekebilable
    {
        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeyle şut çekldi",hiz,mesafe);
        }
    }
}
