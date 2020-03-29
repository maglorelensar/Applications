using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Wİn_InterfaceUygulama
{
    class Defans : Futbolcu, ISavunabilable
    {
        public string SavunmaYap()
        {
            return "Savunma Yapıldı";
        }
    }
}
