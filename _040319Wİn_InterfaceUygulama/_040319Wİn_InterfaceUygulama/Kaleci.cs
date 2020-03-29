using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Wİn_InterfaceUygulama
{
    class Kaleci : Futbolcu, ITopTutabilable
    {
        public string TopTut()
        {
            return "Top Tutuldu";
        }
    }
}
